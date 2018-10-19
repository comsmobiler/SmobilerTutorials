using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoRadioGroup : Smobiler.Core.Controls.MobileForm
    {
        public demoRadioGroup()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioGroup4_ButtonPress(object sender, RadioButtonPressEventArgs e)
        {
            if (e.Button.Checked == true)
                Toast(e.Button.Text + "已选择");
            else
                Toast(e.Button.Text + "已取消选择");
        }

        private void demoRadioGroup_Load(object sender, EventArgs e)
        {
            radioGroup4.SetRadioButtonCheckedByID("1");
        }
    }
}