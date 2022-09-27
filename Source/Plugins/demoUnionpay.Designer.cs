using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoUnionpay : Smobiler.Core.Controls.MobileForm
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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.labOutOrder = new Smobiler.Core.Controls.Label();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            this.unionPay1 = new Smobiler.Plugins.UnionPay();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "UnionPay银联支付";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "生成订单号";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // labOutOrder
            // 
            this.labOutOrder.Location = new System.Drawing.Point(7, 68);
            this.labOutOrder.Name = "labOutOrder";
            this.labOutOrder.Size = new System.Drawing.Size(153, 35);
            this.labOutOrder.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "查询订单";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.Text = "支付";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(170, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.Text = "iOS支付";
            this.button4.Press += new System.EventHandler(this.button4_Press);
            // 
            // unionPay1
            // 
            this.unionPay1.Name = "unionPay1";
            // 
            // demoUnionpay
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.unionPay1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.button1,
            this.labOutOrder,
            this.button2,
            this.button3,
            this.button4});
            this.Name = "demoUnionpay";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button button1;
        private Core.Controls.Label labOutOrder;
        private Core.Controls.Button button2;
        private Core.Controls.Button button3;
        private Core.Controls.Button button4;
        private Smobiler.Plugins.UnionPay unionPay1;
    }
}