using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoKeepAlive : Smobiler.Core.Controls.MobileForm
    {
        public demoKeepAlive() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private bool isIgnor = false;
        private bool isNotication = false;
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            keepAlive1.IsNotication((obj, args) =>
            {

                if (args.isError == false)
                {
                    Toast("通知权限是否开启：" + args.args.ToString());
                    isNotication = true;
                }
                else
                {
                    Toast(args.error);
                }
            });
        }

        private void button2_Press(object sender, EventArgs e)
        {
            keepAlive1.OpenNotication();
        }

        private void button3_Press(object sender, EventArgs e)
        {
            if (isNotication == false || isIgnor == false)
            {
                Toast("通知权限或者后台运行权限未开启，请开启后点击");
                return;
            }
            keepAlive1.StartNotication("应用正在后台运行", "请不要关闭该服务，否则将无法记录您的位置", (obj, args) => {

                if (args.isError == false)
                {
                    Toast("开启：" + args.args.ToString());
                }
                else
                {
                    Toast(args.error);
                }

            });
        }

        private void button4_Press(object sender, EventArgs e)
        {
            if (isNotication == false || isIgnor == false)
            {
                Toast("通知权限或者后台运行权限未开启，请开启后点击");
                return;
            }
            keepAlive1.CloseNotication((obj, args) => {

                if (args.isError == false)
                {
                    Toast("关闭：" + args.args.ToString());
                }
                else
                {
                    Toast(args.error);
                }

            });

        }

        private void button5_Press(object sender, EventArgs e)
        {
            keepAlive1.IsIgnoringBattery((obj, args) => {

                if (args.isError == false)
                {
                    Toast("是否开启：" + args.args.ToString());
                    isIgnor = true;
                }
                else
                {
                    Toast(args.error);
                }

            });
        }

        private void button6_Press(object sender, EventArgs e)
        {
            if (isNotication == false || isIgnor == false)
            {
                Toast("通知权限或者后台运行权限未开启，请开启后点击");
                return;
            }
            keepAlive1.OpenIgnoreSetting((obj, args) => {

                if (args.isError == false)
                {
                    Toast("是否开启：" + args.args.ToString());
                }
                else
                {
                    Toast(args.error);
                }

            });
        }

        private void button7_Press(object sender, EventArgs e)
        {
            keepAlive1.RequestIgnoreBattery((obj, args) => {

                if (args.isError == false)
                {
                    Toast("是否同意：" + args.args.ToString());
                }
                else
                {
                    Toast(args.error);
                }

            });

        }

        private void button8_Press(object sender, EventArgs e)
        {
            if (isNotication == false || isIgnor == false)
            {
                Toast("通知权限或者后台运行权限未开启，请开启后点击");
                return;
            }
            GpsLocationUpdateOptions options = new GpsLocationUpdateOptions();
            options.AmapKey = "";// 测试前请填写高德key 
            options.RequestLocation = true;
            GPS.StartLocationUpdate(this.Client.SessionID, options, (obj, args) => {
                if (args.isError == false)
                {
                    string location = "";
                    if (string.IsNullOrEmpty(args.Location) == false)
                        location = args.Location;
                    labLongitude.Text = args.Longitude.ToString();
                    labLatitude.Text = args.Latitude.ToString();
                    labLocation.Text = args.Location;

                    labTime.Text = DateTime.Now.ToString();
                }
                else
                    Toast(args.error);

            });

        }

        private void button9_Press(object sender, EventArgs e)
        {
            if (isNotication == false || isIgnor == false)
            {
                Toast("通知权限或者后台运行权限未开启，请开启后点击");
                return;
            }
            GPS.StopLocationUpdate(this.Client.SessionID, (obj, args) => {
                if (args.isError == false)
                    Toast("stop");
                else
                    Toast(args.error);
            });

        }
    }
}