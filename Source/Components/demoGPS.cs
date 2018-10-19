using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoGPS : Smobiler.Core.Controls.MobileForm
    {
        public demoGPS()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetGps_Press(object sender, EventArgs e)
        {
            this.gps1.GetGps();
        }

        private void btnGetGpsAsyn_Press(object sender, EventArgs e)
        {
            this.gps1.GetGpsAsyn();
        }

        private void gps1_GotLocation(object sender, GPSResultArgs e)
        {
            lb_Latitude.Text = e.Latitude.ToString();
            lb_Longitude.Text = e.Longitude.ToString();
            lb_Location.Text = e.Location.ToString();
            BD09_Latitude.Text = e.ToBD09().Latitude.ToString();
            BD09_Longitude.Text = e.ToBD09().Longitude.ToString();
            GCJ02_Latitude.Text = e.ToGCJ02().Latitude.ToString();
            GCJ02_Longitude.Text = e.ToGCJ02().Longitude.ToString();
        }
    }
}