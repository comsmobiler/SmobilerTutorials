using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.Layout
{
    partial class demoLoginRelativeLayout : Smobiler.Core.Controls.MobileForm
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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.txtTel = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.txtPwd = new Smobiler.Core.Controls.TextBox();
            this.btnLogon = new Smobiler.Core.Controls.Button();
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.chkRememberPwd = new Smobiler.Core.Controls.CheckBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "arrow-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "demoLoginRelativeLayout";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress_2);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.txtTel,
            this.label1,
            this.label2,
            this.txtPwd,
            this.btnLogon,
            this.line1,
            this.line2,
            this.chkRememberPwd,
            this.label4});
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 470);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(100, 60);
            this.image1.Name = "image1";
            this.image1.ResourceID = "logon";
            this.image1.Size = new System.Drawing.Size(100, 100);
            // 
            // txtTel
            // 
            this.txtTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtTel.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtTel.Location = new System.Drawing.Point(55, 175);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Done;
            this.txtTel.Size = new System.Drawing.Size(230, 40);
            this.txtTel.WaterMarkText = "请输入手机号码";
            // 
            // label1
            // 
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(15, 175);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(40, 40);
            this.label1.Text = "+86";
            // 
            // label2
            // 
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(15, 215);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(40, 40);
            this.label2.Text = "密码";
            // 
            // txtPwd
            // 
            this.txtPwd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPwd.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtPwd.Location = new System.Drawing.Point(55, 215);
            this.txtPwd.MaxLength = 12;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Done;
            this.txtPwd.SecurityMode = true;
            this.txtPwd.Size = new System.Drawing.Size(230, 40);
            this.txtPwd.WaterMarkText = "请输入6-12位密码";
            // 
            // btnLogon
            // 
            this.btnLogon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnLogon.BorderRadius = 4;
            this.btnLogon.FontSize = 15F;
            this.btnLogon.Location = new System.Drawing.Point(15, 295);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(270, 40);
            this.btnLogon.Text = "登录";
            this.btnLogon.Press += new System.EventHandler(this.btnLogon_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.line1.Location = new System.Drawing.Point(15, 215);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(270, 1);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.line2.Location = new System.Drawing.Point(15, 254);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(270, 1);
            // 
            // chkRememberPwd
            // 
            this.chkRememberPwd.Location = new System.Drawing.Point(19, 265);
            this.chkRememberPwd.Name = "chkRememberPwd";
            this.chkRememberPwd.Size = new System.Drawing.Size(20, 20);
            this.chkRememberPwd.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.chkRememberPwd.TintColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(55, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "记住密码";
            // 
            // demoLoginRelativeLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Name = "demoLoginRelativeLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.TextBox txtTel;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.TextBox txtPwd;
        private Smobiler.Core.Controls.Button btnLogon;
        private Smobiler.Core.Controls.Line line1;
        private Smobiler.Core.Controls.Line line2;
        private Smobiler.Core.Controls.CheckBox chkRememberPwd;
        private Smobiler.Core.Controls.Label label4;
    }
}