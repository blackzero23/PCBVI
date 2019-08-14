﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data.Data;

namespace PCBVI.Forms.Basic
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            uscSearch.SetDepartmentSource(DB.Department.GetAll());
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.Basic.Employee.EmployeeSearch.SearchButtonClickedEventArgs e)
        {
            uscList.SetEmployeeDataSource(DB.Employee.SeachEmployeeInfo(e.DepartmentId,e.Name));
        }

        private void UscTopMenu_InsertButtonClicked(object sender, Controls.CommonControl.TopMenubar.InsertButtonClickedEventArgs e)
        {
            uscTopMenu.OpenInsertForm(new EmployeeInsertForm());
        }
    }
}
