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
    partial class editLayout : Smobiler.Core.Controls.MobileUserControl
    {
        public string text1 { get { return textBox1.Text; } }
        public string text2 { get { return textBox2.Text; } }
        public editLayout() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
        public editLayout(string id, string name, string sexual, string img) : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            label2.Text = id;
            textBox1.Text = name;
            textBox2.Text = sexual;
            image1.ResourceID = img;
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Cancel;
            this.Close();
        }

        private void button2_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Yes;
            this.Close();

        }
    }
}