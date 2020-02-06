using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.ShowDialog
{
    partial class userDialogPassword : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public userDialogPassword()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.label1 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.DatePicker = new Smobiler.Core.Controls.DatePicker();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblDealMane = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblLocation = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.btnDone = new Smobiler.Core.Controls.Button();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.palTitle = new Smobiler.Core.Controls.Panel();
            this.ibtClose = new Smobiler.Core.Controls.ImageButton();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.palPassword = new Smobiler.Core.Controls.Panel();
            this.labPass1 = new Smobiler.Core.Controls.Label();
            this.labPass2 = new Smobiler.Core.Controls.Label();
            this.labPass3 = new Smobiler.Core.Controls.Label();
            this.labPass4 = new Smobiler.Core.Controls.Label();
            this.labPass5 = new Smobiler.Core.Controls.Label();
            this.labPass6 = new Smobiler.Core.Controls.Label();
            this.btnForgetPass = new Smobiler.Core.Controls.Button();
            this.palNumPad1 = new Smobiler.Core.Controls.Panel();
            this.btnNum1 = new Smobiler.Core.Controls.Button();
            this.btnNum2 = new Smobiler.Core.Controls.Button();
            this.btnNum3 = new Smobiler.Core.Controls.Button();
            this.palNumPad2 = new Smobiler.Core.Controls.Panel();
            this.btnNum4 = new Smobiler.Core.Controls.Button();
            this.btnNum5 = new Smobiler.Core.Controls.Button();
            this.btnNum6 = new Smobiler.Core.Controls.Button();
            this.palNumPad3 = new Smobiler.Core.Controls.Panel();
            this.btnNum7 = new Smobiler.Core.Controls.Button();
            this.btnNum8 = new Smobiler.Core.Controls.Button();
            this.btnNum9 = new Smobiler.Core.Controls.Button();
            this.palNumPad4 = new Smobiler.Core.Controls.Panel();
            this.button8 = new Smobiler.Core.Controls.Button();
            this.btnNum0 = new Smobiler.Core.Controls.Button();
            this.ibtnBack = new Smobiler.Core.Controls.ImageButton();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.Text = "调入管理员";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 35);
            this.textBox1.WaterMarkText = "调入管理员";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 35);
            this.label5.Text = "业务日期";
            // 
            // DatePicker
            // 
            this.DatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.DatePicker.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.DatePicker.Location = new System.Drawing.Point(88, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(212, 35);
            // 
            // Label3
            // 
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 35);
            this.Label3.Text = "处理人";
            // 
            // lblDealMane
            // 
            this.lblDealMane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblDealMane.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblDealMane.Location = new System.Drawing.Point(88, 0);
            this.lblDealMane.Name = "lblDealMane";
            this.lblDealMane.Size = new System.Drawing.Size(212, 35);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 35);
            this.label2.Text = "选择区域";
            // 
            // lblLocation
            // 
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lblLocation.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblLocation.Location = new System.Drawing.Point(88, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(212, 35);
            // 
            // label4
            // 
            this.label4.Flex = 1;
            this.label4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.Text = "输入内容";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDone.ForeColor = System.Drawing.Color.Black;
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 30);
            this.btnDone.Text = "完成";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 70);
            this.label6.Text = "备注";
            this.label6.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 70);
            this.textBox2.WaterMarkText = "备注";
            // 
            // palTitle
            // 
            this.palTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.palTitle.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.ibtClose,
            this.label7});
            this.palTitle.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.palTitle.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.palTitle.Name = "palTitle";
            this.palTitle.Size = new System.Drawing.Size(0, 30);
            // 
            // ibtClose
            // 
            this.ibtClose.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.ibtClose.Name = "ibtClose";
            this.ibtClose.ResourceID = "times";
            this.ibtClose.Size = new System.Drawing.Size(37, 0);
            this.ibtClose.Press += new System.EventHandler(this.ibtClose_Press);
            // 
            // label7
            // 
            this.label7.Flex = 1;
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.Text = "请输入支付密码";
            // 
            // palPassword
            // 
            this.palPassword.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labPass1,
            this.labPass2,
            this.labPass3,
            this.labPass4,
            this.labPass5,
            this.labPass6});
            this.palPassword.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.palPassword.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.palPassword.Margin = new Smobiler.Core.Controls.Margin(10F, 10F, 10F, 0F);
            this.palPassword.Name = "palPassword";
            this.palPassword.Size = new System.Drawing.Size(0, 50);
            // 
            // labPass1
            // 
            this.labPass1.Border = new Smobiler.Core.Controls.Border(1F);
            this.labPass1.BorderColor = System.Drawing.Color.Silver;
            this.labPass1.Flex = 1;
            this.labPass1.FontSize = 30F;
            this.labPass1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labPass1.Name = "labPass1";
            this.labPass1.Size = new System.Drawing.Size(0, 0);
            // 
            // labPass2
            // 
            this.labPass2.Border = new Smobiler.Core.Controls.Border(1F);
            this.labPass2.BorderColor = System.Drawing.Color.Silver;
            this.labPass2.Flex = 1;
            this.labPass2.FontSize = 30F;
            this.labPass2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labPass2.Name = "labPass2";
            this.labPass2.Size = new System.Drawing.Size(0, 0);
            // 
            // labPass3
            // 
            this.labPass3.Border = new Smobiler.Core.Controls.Border(1F);
            this.labPass3.BorderColor = System.Drawing.Color.Silver;
            this.labPass3.Flex = 1;
            this.labPass3.FontSize = 30F;
            this.labPass3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labPass3.Name = "labPass3";
            this.labPass3.Size = new System.Drawing.Size(0, 0);
            // 
            // labPass4
            // 
            this.labPass4.Border = new Smobiler.Core.Controls.Border(1F);
            this.labPass4.BorderColor = System.Drawing.Color.Silver;
            this.labPass4.Flex = 1;
            this.labPass4.FontSize = 30F;
            this.labPass4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labPass4.Name = "labPass4";
            this.labPass4.Size = new System.Drawing.Size(0, 0);
            // 
            // labPass5
            // 
            this.labPass5.Border = new Smobiler.Core.Controls.Border(1F);
            this.labPass5.BorderColor = System.Drawing.Color.Silver;
            this.labPass5.Flex = 1;
            this.labPass5.FontSize = 30F;
            this.labPass5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labPass5.Name = "labPass5";
            this.labPass5.Size = new System.Drawing.Size(0, 0);
            // 
            // labPass6
            // 
            this.labPass6.Border = new Smobiler.Core.Controls.Border(1F);
            this.labPass6.BorderColor = System.Drawing.Color.Silver;
            this.labPass6.Flex = 1;
            this.labPass6.FontSize = 30F;
            this.labPass6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labPass6.Name = "labPass6";
            this.labPass6.Size = new System.Drawing.Size(0, 0);
            // 
            // btnForgetPass
            // 
            this.btnForgetPass.BackColor = System.Drawing.Color.Transparent;
            this.btnForgetPass.BorderRadius = 0;
            this.btnForgetPass.ForeColor = System.Drawing.Color.Blue;
            this.btnForgetPass.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnForgetPass.Name = "btnForgetPass";
            this.btnForgetPass.Size = new System.Drawing.Size(0, 30);
            this.btnForgetPass.Text = "忘记密码？";
            this.btnForgetPass.Press += new System.EventHandler(this.btnForgetPass_Press);
            // 
            // palNumPad1
            // 
            this.palNumPad1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnNum1,
            this.btnNum2,
            this.btnNum3});
            this.palNumPad1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.palNumPad1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.palNumPad1.Name = "palNumPad1";
            this.palNumPad1.Size = new System.Drawing.Size(0, 50);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.Transparent;
            this.btnNum1.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnNum1.BorderColor = System.Drawing.Color.LightBlue;
            this.btnNum1.BorderRadius = 0;
            this.btnNum1.FontSize = 40F;
            this.btnNum1.ForeColor = System.Drawing.Color.Black;
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(100, 0);
            this.btnNum1.Text = "1";
            this.btnNum1.Press += new System.EventHandler(this.btnNum_Press);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.Transparent;
            this.btnNum2.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnNum2.BorderColor = System.Drawing.Color.LightBlue;
            this.btnNum2.BorderRadius = 0;
            this.btnNum2.FontSize = 40F;
            this.btnNum2.ForeColor = System.Drawing.Color.Black;
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(100, 0);
            this.btnNum2.Text = "2";
            this.btnNum2.Press += new System.EventHandler(this.btnNum_Press);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.Transparent;
            this.btnNum3.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnNum3.BorderColor = System.Drawing.Color.LightBlue;
            this.btnNum3.BorderRadius = 0;
            this.btnNum3.FontSize = 40F;
            this.btnNum3.ForeColor = System.Drawing.Color.Black;
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(100, 0);
            this.btnNum3.Text = "3";
            this.btnNum3.Press += new System.EventHandler(this.btnNum_Press);
            // 
            // palNumPad2
            // 
            this.palNumPad2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnNum4,
            this.btnNum5,
            this.btnNum6});
            this.palNumPad2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.palNumPad2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.palNumPad2.Name = "palNumPad2";
            this.palNumPad2.Size = new System.Drawing.Size(0, 50);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.Transparent;
            this.btnNum4.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnNum4.BorderColor = System.Drawing.Color.LightBlue;
            this.btnNum4.BorderRadius = 0;
            this.btnNum4.FontSize = 40F;
            this.btnNum4.ForeColor = System.Drawing.Color.Black;
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(100, 0);
            this.btnNum4.Text = "4";
            this.btnNum4.Press += new System.EventHandler(this.btnNum_Press);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.Transparent;
            this.btnNum5.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnNum5.BorderColor = System.Drawing.Color.LightBlue;
            this.btnNum5.BorderRadius = 0;
            this.btnNum5.FontSize = 40F;
            this.btnNum5.ForeColor = System.Drawing.Color.Black;
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(100, 0);
            this.btnNum5.Text = "5";
            this.btnNum5.Press += new System.EventHandler(this.btnNum_Press);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.Transparent;
            this.btnNum6.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnNum6.BorderColor = System.Drawing.Color.LightBlue;
            this.btnNum6.BorderRadius = 0;
            this.btnNum6.FontSize = 40F;
            this.btnNum6.ForeColor = System.Drawing.Color.Black;
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(100, 0);
            this.btnNum6.Text = "6";
            this.btnNum6.Press += new System.EventHandler(this.btnNum_Press);
            // 
            // palNumPad3
            // 
            this.palNumPad3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnNum7,
            this.btnNum8,
            this.btnNum9});
            this.palNumPad3.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.palNumPad3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.palNumPad3.Name = "palNumPad3";
            this.palNumPad3.Size = new System.Drawing.Size(0, 50);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.Color.Transparent;
            this.btnNum7.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnNum7.BorderColor = System.Drawing.Color.LightBlue;
            this.btnNum7.BorderRadius = 0;
            this.btnNum7.FontSize = 40F;
            this.btnNum7.ForeColor = System.Drawing.Color.Black;
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(100, 0);
            this.btnNum7.Text = "7";
            this.btnNum7.Press += new System.EventHandler(this.btnNum_Press);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.Color.Transparent;
            this.btnNum8.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnNum8.BorderColor = System.Drawing.Color.LightBlue;
            this.btnNum8.BorderRadius = 0;
            this.btnNum8.FontSize = 40F;
            this.btnNum8.ForeColor = System.Drawing.Color.Black;
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(100, 0);
            this.btnNum8.Text = "8";
            this.btnNum8.Press += new System.EventHandler(this.btnNum_Press);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.Color.Transparent;
            this.btnNum9.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnNum9.BorderColor = System.Drawing.Color.LightBlue;
            this.btnNum9.BorderRadius = 0;
            this.btnNum9.FontSize = 40F;
            this.btnNum9.ForeColor = System.Drawing.Color.Black;
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(100, 0);
            this.btnNum9.Text = "9";
            this.btnNum9.Press += new System.EventHandler(this.btnNum_Press);
            // 
            // palNumPad4
            // 
            this.palNumPad4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.palNumPad4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button8,
            this.btnNum0,
            this.ibtnBack});
            this.palNumPad4.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.palNumPad4.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.palNumPad4.Name = "palNumPad4";
            this.palNumPad4.Size = new System.Drawing.Size(0, 50);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Border = new Smobiler.Core.Controls.Border(1F);
            this.button8.BorderColor = System.Drawing.Color.LightBlue;
            this.button8.BorderRadius = 0;
            this.button8.FontSize = 40F;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 0);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.Color.White;
            this.btnNum0.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnNum0.BorderColor = System.Drawing.Color.LightBlue;
            this.btnNum0.BorderRadius = 0;
            this.btnNum0.FontSize = 40F;
            this.btnNum0.ForeColor = System.Drawing.Color.Black;
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(100, 0);
            this.btnNum0.Text = "0";
            this.btnNum0.Press += new System.EventHandler(this.btnNum_Press);
            // 
            // ibtnBack
            // 
            this.ibtnBack.Border = new Smobiler.Core.Controls.Border(1F);
            this.ibtnBack.BorderColor = System.Drawing.Color.LightBlue;
            this.ibtnBack.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.ResourceID = "times-circle-o";
            this.ibtnBack.Size = new System.Drawing.Size(100, 0);
            this.ibtnBack.Press += new System.EventHandler(this.ibtnBack_Press);
            // 
            // userDialogPassword
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.palTitle,
            this.palPassword,
            this.btnForgetPass,
            this.palNumPad1,
            this.palNumPad2,
            this.palNumPad3,
            this.palNumPad4});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(0, 320);
            this.Name = "userDialogPassword";

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.DatePicker DatePicker;
        private Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label lblDealMane;
        private Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label lblLocation;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Button btnDone;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.TextBox textBox2;
        private Smobiler.Core.Controls.Panel palTitle;
        private Smobiler.Core.Controls.ImageButton ibtClose;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Panel palPassword;
        private Smobiler.Core.Controls.Label labPass1;
        private Smobiler.Core.Controls.Label labPass2;
        private Smobiler.Core.Controls.Label labPass3;
        private Smobiler.Core.Controls.Label labPass4;
        private Smobiler.Core.Controls.Label labPass5;
        private Smobiler.Core.Controls.Label labPass6;
        private Smobiler.Core.Controls.Button btnForgetPass;
        private Smobiler.Core.Controls.Panel palNumPad1;
        private Smobiler.Core.Controls.Button btnNum1;
        private Smobiler.Core.Controls.Button btnNum2;
        private Smobiler.Core.Controls.Button btnNum3;
        private Smobiler.Core.Controls.Panel palNumPad2;
        private Smobiler.Core.Controls.Button btnNum4;
        private Smobiler.Core.Controls.Button btnNum5;
        private Smobiler.Core.Controls.Button btnNum6;
        private Smobiler.Core.Controls.Panel palNumPad3;
        private Smobiler.Core.Controls.Button btnNum7;
        private Smobiler.Core.Controls.Button btnNum8;
        private Smobiler.Core.Controls.Button btnNum9;
        private Smobiler.Core.Controls.Panel palNumPad4;
        private Smobiler.Core.Controls.Button btnNum0;
        private Smobiler.Core.Controls.ImageButton ibtnBack;
        private Smobiler.Core.Controls.Button button8;
    }
}