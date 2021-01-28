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
    partial class tableTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public tableTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ((demoListView)this.Form).countAll(checkBox1, label1.Text, label2.Text, label3.Text);
        }
    }
}