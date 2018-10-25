using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoHTMLView : Smobiler.Core.Controls.MobileForm
    {
        public demoHTMLView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoHTMLView_Load(object sender, EventArgs e)
        {
            htmlView1.HTML = "<h1>This HTML snippet is now rendered with native components !</h1><h2> Enjoy a webview-free and blazing fast application</h2><img src=\"https://i.imgur.com/dHLmxfO.jpg?2\" /><em style=\"textAlign: center;\" > Look at how happy this native cat is</em>";
        }
    }
}