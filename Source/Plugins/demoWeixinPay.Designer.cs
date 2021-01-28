using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoWeixinPay : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnWXPay = new Smobiler.Core.Controls.Button();
            this.btnWXLogin = new Smobiler.Core.Controls.Button();
            this.btnOutOrder = new Smobiler.Core.Controls.Button();
            this.labOutOrder = new Smobiler.Core.Controls.Label();
            this.weiXin1 = new Smobiler.Plugins.WeiXin();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "WeiXin";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnWXPay,
            this.btnWXLogin,
            this.btnOutOrder,
            this.labOutOrder});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 477);
            // 
            // btnWXPay
            // 
            this.btnWXPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btnWXPay.Location = new System.Drawing.Point(8, 48);
            this.btnWXPay.Name = "btnWXPay";
            this.btnWXPay.Size = new System.Drawing.Size(100, 42);
            this.btnWXPay.Text = "支付1分钱";
            this.btnWXPay.Press += new System.EventHandler(this.btnWXPay_Press);
            // 
            // btnWXLogin
            // 
            this.btnWXLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnWXLogin.Location = new System.Drawing.Point(183, 48);
            this.btnWXLogin.Name = "btnWXLogin";
            this.btnWXLogin.Size = new System.Drawing.Size(106, 42);
            this.btnWXLogin.Text = "微信登陆";
            this.btnWXLogin.Press += new System.EventHandler(this.btnWXLogin_Press);
            // 
            // btnOutOrder
            // 
            this.btnOutOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(80)))));
            this.btnOutOrder.Location = new System.Drawing.Point(200, 1);
            this.btnOutOrder.Name = "btnOutOrder";
            this.btnOutOrder.Size = new System.Drawing.Size(100, 35);
            this.btnOutOrder.Text = "生成外部订单号";
            this.btnOutOrder.Press += new System.EventHandler(this.btnOutOrder_Press);
            // 
            // labOutOrder
            // 
            this.labOutOrder.Location = new System.Drawing.Point(0, 1);
            this.labOutOrder.Name = "labOutOrder";
            this.labOutOrder.Size = new System.Drawing.Size(200, 35);
            // 
            // weiXin1
            // 
            this.weiXin1.Name = "weiXin1";
            // 
            // demoWeixinPay
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.weiXin1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Load += new System.EventHandler(this.demoWeixinPay_Load);
            this.Name = "demoWeixinPay";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Button btnWXPay;
        private Core.Controls.Button btnWXLogin;
        private Core.Controls.Button btnOutOrder;
        private Core.Controls.Label labOutOrder;
        private Smobiler.Plugins.WeiXin weiXin1;
    }
}