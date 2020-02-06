using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.ShowDialog
{
    partial class userFooterDialog : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public userFooterDialog()
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
            this.plTDInMan = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.plDate = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.DatePicker = new Smobiler.Core.Controls.DatePicker();
            this.plDealMan = new Smobiler.Core.Controls.Panel();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.lblDealMane = new Smobiler.Core.Controls.Label();
            this.plLocation = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblLocation = new Smobiler.Core.Controls.Label();
            this.plNote = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.btnDone = new Smobiler.Core.Controls.Button();
            // 
            // plTDInMan
            // 
            this.plTDInMan.BackColor = System.Drawing.Color.White;
            this.plTDInMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plTDInMan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.textBox1});
            this.plTDInMan.Name = "plTDInMan";
            this.plTDInMan.Size = new System.Drawing.Size(300, 35);
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
            // plDate
            // 
            this.plDate.BackColor = System.Drawing.Color.White;
            this.plDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plDate.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.DatePicker});
            this.plDate.Name = "plDate";
            this.plDate.Size = new System.Drawing.Size(300, 35);
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
            // plDealMan
            // 
            this.plDealMan.BackColor = System.Drawing.Color.White;
            this.plDealMan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plDealMan.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label3,
            this.lblDealMane});
            this.plDealMan.Name = "plDealMan";
            this.plDealMan.Size = new System.Drawing.Size(300, 35);
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
            // plLocation
            // 
            this.plLocation.BackColor = System.Drawing.Color.White;
            this.plLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plLocation.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.lblLocation});
            this.plLocation.Name = "plLocation";
            this.plLocation.Size = new System.Drawing.Size(300, 35);
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
            // plNote
            // 
            this.plNote.BackColor = System.Drawing.Color.White;
            this.plNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plNote.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6,
            this.textBox2});
            this.plNote.Name = "plNote";
            this.plNote.Size = new System.Drawing.Size(300, 70);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.btnDone});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.FlexStart;
            this.panel1.JustifyAlign = Smobiler.Core.Controls.LayoutJustifyAlign.FlexEnd;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 30);
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
            this.btnDone.Press += new System.EventHandler(this.btnDone_Press);
            // 
            // userFooterDialog
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.plTDInMan,
            this.plDate,
            this.plDealMan,
            this.plLocation,
            this.plNote});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "userFooterDialog";

        }
        #endregion

        private Smobiler.Core.Controls.Panel plTDInMan;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Panel plDate;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.DatePicker DatePicker;
        private Smobiler.Core.Controls.Panel plDealMan;
        private Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label lblDealMane;
        private Smobiler.Core.Controls.Panel plLocation;
        private Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label lblLocation;
        private Smobiler.Core.Controls.Panel plNote;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.TextBox textBox2;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Button btnDone;
    }
}