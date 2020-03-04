using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples
{
    partial class demoTwoWayScrolling : Smobiler.Core.Controls.MobileForm
    {
        public demoTwoWayScrolling() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void demoTwoWayScrolling_Load(object sender, EventArgs e)
        {
            panel1.Scrollable = true;
            panel1.Direction = LayoutDirection.Row;
            panel1.Horizontal = true;
            panel1.Layout = LayoutPosition.Relative;
            panel2.Scrollable = true;

            for(int i=0;i<20;i++)
            {
                panel2.Controls.Add(new Label() { Width=0,Text = "Label" + i,Border=new Border(0,0,0,1)});
            }
            for (int i = 0; i < 20; i++)
            {
                panel4.Controls.Add(new Label() { Width = 600, Text = "Label" + i, Border = new Border(0, 0, 0, 1) });
            }
        }
    }
}