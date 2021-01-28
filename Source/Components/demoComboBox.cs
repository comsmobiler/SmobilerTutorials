using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoComboBox : Smobiler.Core.Controls.MobileForm
    {
        public demoComboBox() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }


        private void demoComboBox_Load(object sender, EventArgs e)
        {
            comboBox1.Items = new string[] { "item1", "item2", "item3" };
            comboBox2.Items = new string[] { "item1", "item2", "item3" };
            comboBox3.Items = new string[] { "item1", "item2", "item3" };
           
        }

        private void comboBox3_ItemSelected(object sender, EventArgs e)
        {
            Toast("当前选择："+comboBox3.Text);
        }

     
    }
}