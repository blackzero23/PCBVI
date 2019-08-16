﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBVI.Data.Data;

namespace PCBVI.Controls.Facilities
{
    public partial class FacilitiesHLC : UserControl
    {
        public FacilitiesHLC()
        {
            InitializeComponent();
            
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;

            InitSetDataSource();
        }
        public void InitSetDataSource()
        {
            bdsWorkPlace.DataSource = DB.WorkPlace.GetAll();
            bdsFacilities.DataSource = DB.Facilities.GetAll();
            bdsFHistoryDivision.DataSource = DB.FHistoryDivision.GetAll();
        }

        public void SetDataSource(List<Data.FacilitiesHistory> list)
        {
            dgvList.DataSource = list;
        }
    }
}
