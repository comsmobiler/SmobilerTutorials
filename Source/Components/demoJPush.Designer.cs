using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoJPush : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.title1 = new Smobiler.Core.Controls.Title();
            this.scrollPanel1 = new Smobiler.Core.Controls.Panel();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            this.button6 = new Smobiler.Core.Controls.Button();
            this.button8 = new Smobiler.Core.Controls.Button();
            this.button10 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button5 = new Smobiler.Core.Controls.Button();
            this.button7 = new Smobiler.Core.Controls.Button();
            this.button9 = new Smobiler.Core.Controls.Button();
            this.button11 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "JPush";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // scrollPanel1
            // 
            this.scrollPanel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.textBox1,
            this.textBox2,
            this.label3,
            this.button1,
            this.label1,
            this.button2,
            this.button4,
            this.button6,
            this.button8,
            this.button10,
            this.label2,
            this.button3,
            this.button5,
            this.button7,
            this.button9,
            this.button11});
            this.scrollPanel1.Flex = 1;
            this.scrollPanel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.scrollPanel1.Name = "scrollPanel1";
            this.scrollPanel1.Scrollable = true;
            this.scrollPanel1.Size = new System.Drawing.Size(300, 470);
            // 
            // textBox1
            // 
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 30);
            this.textBox1.Text = "devices";
            this.textBox1.WaterMarkText = "别名";
            // 
            // textBox2
            // 
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 30);
            this.textBox2.Text = "Push content";
            this.textBox2.WaterMarkText = "推送内容";
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.Text = "绑定别名";
            // 
            // button1
            // 
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 30);
            this.button1.Text = "设置别名（devices）";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.Text = "向指定设备";
            // 
            // button2
            // 
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 30);
            this.button2.Text = "向指定设备推送消息（应用弹出）";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button4
            // 
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 30);
            this.button4.Text = "向指定设备推送通知（抬头栏）";
            this.button4.Press += new System.EventHandler(this.button4_Press);
            // 
            // button6
            // 
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(0, 30);
            this.button6.Text = "指定推送点击跳转URL链接的消息";
            this.button6.Press += new System.EventHandler(this.button6_Press);
            // 
            // button8
            // 
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(0, 30);
            this.button8.Text = "指定推送点击触发客户端回调的消息";
            this.button8.Press += new System.EventHandler(this.button8_Press);
            // 
            // button10
            // 
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(0, 30);
            this.button10.Text = "向指定设备推送通知（抬头栏）大段文本样式";
            this.button10.Press += new System.EventHandler(this.button10_Press);
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.Text = "向全部设备";
            // 
            // button3
            // 
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 30);
            this.button3.Text = "向全部设备推送消息（应用弹出）";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // button5
            // 
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 30);
            this.button5.Text = "向全部设备推送通知（抬头栏）";
            this.button5.Press += new System.EventHandler(this.button5_Press);
            // 
            // button7
            // 
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(0, 30);
            this.button7.Text = "全部推送点击跳转URL链接的消息";
            this.button7.Press += new System.EventHandler(this.button7_Press);
            // 
            // button9
            // 
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(0, 30);
            this.button9.Text = "全部推送点击触发客户端回调的消息";
            this.button9.Press += new System.EventHandler(this.button9_Press);
            // 
            // button11
            // 
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(0, 30);
            this.button11.Text = "向全部设备推送通知（抬头栏）大段文本样式";
            this.button11.Press += new System.EventHandler(this.button11_Press);
            // 
            // demoJPush
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.scrollPanel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoJPush";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel scrollPanel1;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.TextBox textBox2;
        private Core.Controls.Label label3;
        private Core.Controls.Button button1;
        private Core.Controls.Label label1;
        private Core.Controls.Button button2;
        private Core.Controls.Button button4;
        private Core.Controls.Button button6;
        private Core.Controls.Button button8;
        private Core.Controls.Button button10;
        private Core.Controls.Label label2;
        private Core.Controls.Button button3;
        private Core.Controls.Button button5;
        private Core.Controls.Button button7;
        private Core.Controls.Button button9;
        private Core.Controls.Button button11;
    }
}