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
    partial class frmUser : Smobiler.Core.Controls.MobileUserControl
    {
        public frmUser() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            //this.Form.Close();
        }

        private void ImgUser_Press(object sender, EventArgs e)
        {

        }

        private void Img_Press(object sender, EventArgs e)
        {

        }

        private void btnSex_Press(object sender, EventArgs e)
        {

        }

        private void txtLocation_TouchLeave(object sender, EventArgs e)
        {

        }

        private void dpkBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }
    }
}