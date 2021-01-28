using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoMapRoute : Smobiler.Core.Controls.MobileForm
    {
        public demoMapRoute() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Press(object sender, EventArgs e)
        {
            mapRoute1.Clear();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            System.Drawing.Point[] points = new System.Drawing.Point[4];//路径上的点
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 3; j++)
                    points[i] = new System.Drawing.Point(i * 10, j + 3);
            mapRoute1.DrawRoute(points);

        }
    }
}