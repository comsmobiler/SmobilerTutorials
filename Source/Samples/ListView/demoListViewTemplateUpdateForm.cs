using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples.ListView
{
    partial class demoListViewTemplateUpdateForm : Smobiler.Core.Controls.MobileForm
    {
        public demoListViewTemplateUpdateForm() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        public string text1 { get { return textBox1.Text; } }
        public string text2 { get { return textBox2.Text; } }
        public demoListViewTemplateUpdateForm(string textbox1,string textbox2) : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            textBox1.Text = textbox1;
            textBox2.Text = textbox2;
        }
  
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Yes;
            this.Close();
        }


    }
}