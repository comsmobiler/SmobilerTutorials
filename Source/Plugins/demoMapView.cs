using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Plugins;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoMapView : Smobiler.Core.Controls.MobileForm
    {
        public demoMapView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mapView1_TagClick(object sender, Smobiler.Plugins.MapViewTagClickEventArgs e)
        {
            Toast("Press");
        }

        private void button1_Press(object sender, EventArgs e)
        {
            gps1.GetGps();
        }

        private void gps1_GotLocation(object sender, GPSResultArgs e)
        { //mapview1.GeoType 若是设置BD09，则要使用e.ToBD09().Latitude
            double latitude =e.ToGCJ02().Latitude;
            double longitude =e.ToGCJ02().Longitude;
            mapView1.Tags.Add(new Smobiler.Plugins.MapViewTag(longitude, latitude, e.Location));
        }

        private void button2_Press(object sender, EventArgs e)
        {
            MapViewRoute route = new MapViewRoute();
            route.Point.Add(new MapViewPoint(121.499718, 31.239703, "上海东方明珠"));
            mapView1.Routes.Add(route);

            MapViewRoute route1 = new MapViewRoute();
            route1.Point.Add(new MapViewPoint(121.501909, 31.240777, "海洋馆"));
            mapView1.Routes.Add(route1);

            MapViewRoute route2 = new MapViewRoute();
            route2.Point.Add(new MapViewPoint(121.214778, 31.09607, "上海欢乐谷"));
            mapView1.Routes.Add(route2);

            MapViewRoute route3 = new MapViewRoute();
            route3.Point.Add(new MapViewPoint(121.667003, 31.141447, "上海迪士尼度假区"));
            mapView1.Routes.Add(route3);

            MapViewRoute route4 = new MapViewRoute();
            route4.Point.Add(new MapViewPoint(121.372423, 31.138893, "水上乐园"));
            mapView1.Routes.Add(route4);

            MapViewRoute route5 = new MapViewRoute();
            route5.Point.Add(new MapViewPoint(121.196632, 31.094513, "上海佘山森林公园"));
            mapView1.Routes.Add(route5);

            MapViewRoute route6 = new MapViewRoute();
            route6.Point.Add(new MapViewPoint(121.444345, 31.147221, "上海植物园"));
            mapView1.Routes.Add(route6);


        }

        private void button3_Press(object sender, EventArgs e)
        {
            mapView1.Routes.Clear();
        }
    }
}