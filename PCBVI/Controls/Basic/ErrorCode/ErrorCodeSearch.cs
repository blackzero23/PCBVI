﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBVI.Controls.Basic.ErrorCode
{
    public partial class ErrorCodeSearch : UserControl
    {
        public ErrorCodeSearch()
        {
            InitializeComponent();
        }
        //usc형태의 콤보박스바인딩
        //콤보박스바인딩
        //

        public void SetErrorcodeDataSource(List<PCBVI.Data.ErrorCode> list)
        {
            
            cbbErrorCode.DataSource = list;
        }
       
    }
}
