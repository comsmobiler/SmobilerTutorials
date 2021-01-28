using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class listViewTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public listViewTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void panel1_Press(object sender, EventArgs e)
        {
            editLayout lp = new editLayout(label1.BindDataValue.ToString(), label1.Text, label2.Text, image1.ResourceID);
            this.Form.ShowDialog(lp, (obj, args) =>
            {
                if (lp.ShowResult == ShowResult.Yes)
                {
                    label1.Text = lp.text1;
                    label2.Text = lp.text2;
                }
            });
        }
    }
}