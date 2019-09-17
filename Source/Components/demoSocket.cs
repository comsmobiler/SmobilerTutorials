using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Core.RPC;

namespace Smobiler.Tutorials.Components
{
    partial class demoSocket : Smobiler.Core.Controls.MobileForm
    {
        public demoSocket() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private MobileSocket socket;

        private void demoSocket_Load(object sender, EventArgs e)
        {
            label1.Text = "Connect方法打开连接，Send方法发送数据，IsOpen方法获取连接状态，Close方法关闭连接，DataReceived事件在获取到数据时发生 ";
            socket = this.Client.Socket.Create(this.Client.HostAddress, this.Client.HostTcpPort);
            socket.DataReceived += (obj, args) =>
            {
                if (args.isError == true)
                {
                    Toast(string.Format("接收异常: errorCode {0}/ errorInfo {1}", args.errorCode, args.error));
                }
                else
                {
                    Toast(string.Format("接收到数据: {0}", System.Convert.ToBase64String(args.Data)));
                }

            };

        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        //打开连接
        private void button1_Press(object sender, EventArgs e)
        {
            socket.Connect((obj, args) =>
            {
                if (args.isError == true)
                {
                    Toast(string.Format("连接失败: errorCode {0}/ errorInfo {1}", args.errorCode, args.error));
                }
                else
                {
                    Toast("连接成功");
                }
            });

        }
        //发送数据
        private void button2_Press(object sender, EventArgs e)
        {
            socket.Send(new byte[] { 24, 0, 0, 0, 1, 0, 0, 0, 0 }, (obj, args) =>
            {
                if (args.isError == true)
                {
                    Toast(string.Format("发送失败: errorCode {0}/ errorInfo {1}", args.errorCode, args.error));
                }
                else
                {
                    Toast("发送成功");
                }
            });

        }
        //获取状态
        private void button3_Press(object sender, EventArgs e)
        {
            socket.IsOpen((obj, args) =>
            {
                if (args.isError == true)
                {
                    Toast(string.Format("获取失败: errorCode {0}/ errorInfo {1}", args.errorCode, args.error));
                }
                else
                {
                    Toast("IsOpen状态" + args.IsOpen.ToString());
                }
            });

        }
        //关闭
        private void button4_Press(object sender, EventArgs e)
        {
            socket.Close((obj, args) =>
            {
                if (args.isError == true)
                {
                    Toast(string.Format("关闭失败: errorCode {0}/ errorInfo {1}", args.errorCode, args.error));
                }
                else
                {
                    Toast("关闭成功");
                }
            });

        }
    }
}