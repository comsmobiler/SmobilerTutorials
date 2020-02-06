using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples.Layout.UserControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmOrder : Smobiler.Core.Controls.MobileUserControl
    {
        public frmOrder() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            //this.Form.Close();
        }

        private void scType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAss_Press(object sender, EventArgs e)
        {

        }

        private void btnCon_Press(object sender, EventArgs e)
        {

        }
    }
}