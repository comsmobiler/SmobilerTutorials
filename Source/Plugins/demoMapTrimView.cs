using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoMapTrimView : Smobiler.Core.Controls.MobileForm
    {
        public demoMapTrimView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mapTrimView1_LocationChanged(object sender, Smobiler.Plugins.MapTrimViewLocationChangedEventArgs e)
        {

            if ((!e.Longitude.Equals(mapTrimView1.Longitude)) & (!e.Latitude.Equals(mapTrimView1.Latitude)))
            {
                MessageBox.Show("是否确定更改地点？", "地点微调", MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                {
                    if (args.Result == Smobiler.Core.Controls.ShowResult.Yes)
                    {
                        float Longitude = e.Longitude;//得到更改地点的经度
                        float Latitude = e.Latitude;//得到更改地点的纬度
                        string addressInfo = e.Description;//得到更改地点的位置信息
                    }
                });
            }
        }

        private void button1_Press(object sender, EventArgs e)
        {
            gps1.GetGps();
        }

        private void gps1_GotLocation(object sender, GPSResultArgs e)
        {
            //maptrimview1.GeoType 若是设置BD09，则要使用e.ToBD09().Latitude
            mapTrimView1.Longitude =(float) e.ToGCJ02().Longitude;
            mapTrimView1.Latitude = (float)e.ToGCJ02().Latitude;
        }
    }
}