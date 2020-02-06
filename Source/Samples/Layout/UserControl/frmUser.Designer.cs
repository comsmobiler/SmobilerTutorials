using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.Layout.UserControl
{
    partial class frmUser : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

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
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.plImage = new Smobiler.Core.Controls.Panel();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.imgEdit = new Smobiler.Core.Controls.ImageButton();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.plSex = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnSex = new Smobiler.Core.Controls.Button();
            this.plAddress = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.txtAddress = new Smobiler.Core.Controls.TextBox();
            this.plBirthday = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.dpkBirthday = new Smobiler.Core.Controls.DatePicker();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.plUser = new Smobiler.Core.Controls.Panel();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.lblID = new Smobiler.Core.Controls.Label();
            this.plTel = new Smobiler.Core.Controls.Panel();
            this.Label2 = new Smobiler.Core.Controls.Label();
            this.lblPhone = new Smobiler.Core.Controls.Label();
            this.plEmail = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblEmail = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "设置";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plImage,
            this.plSex,
            this.plAddress,
            this.plBirthday,
            this.label6,
            this.plUser,
            this.plTel,
            this.plEmail});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // plImage
            // 
            this.plImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.plImage.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblName,
            this.imgEdit,
            this.image1});
            this.plImage.Name = "plImage";
            this.plImage.Size = new System.Drawing.Size(300, 140);
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblName.Location = new System.Drawing.Point(106, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 31);
            this.lblName.Text = "用户";
            // 
            // imgEdit
            // 
            this.imgEdit.IconColor = System.Drawing.Color.White;
            this.imgEdit.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imgEdit.Location = new System.Drawing.Point(194, 100);
            this.imgEdit.Name = "imgEdit";
            this.imgEdit.ResourceID = "pencil";
            this.imgEdit.Size = new System.Drawing.Size(25, 25);
            this.imgEdit.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.imgEdit.Press += new System.EventHandler(this.Img_Press);
            // 
            // image1
            // 
            this.image1.BorderRadius = 44;
            this.image1.Location = new System.Drawing.Point(106, 21);
            this.image1.Name = "image1";
            this.image1.ResourceID = "logon";
            this.image1.Size = new System.Drawing.Size(80, 79);
            // 
            // plSex
            // 
            this.plSex.BackColor = System.Drawing.Color.White;
            this.plSex.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plSex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plSex.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.btnSex});
            this.plSex.Location = new System.Drawing.Point(0, 140);
            this.plSex.Name = "plSex";
            this.plSex.Size = new System.Drawing.Size(300, 35);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.Text = "性别";
            // 
            // btnSex
            // 
            this.btnSex.BackColor = System.Drawing.Color.Transparent;
            this.btnSex.BorderRadius = 0;
            this.btnSex.ForeColor = System.Drawing.Color.Black;
            this.btnSex.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnSex.Location = new System.Drawing.Point(80, 0);
            this.btnSex.Name = "btnSex";
            this.btnSex.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.btnSex.Size = new System.Drawing.Size(220, 35);
            this.btnSex.Text = "男   >";
            this.btnSex.Press += new System.EventHandler(this.btnSex_Press);
            // 
            // plAddress
            // 
            this.plAddress.BackColor = System.Drawing.Color.White;
            this.plAddress.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plAddress.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.txtAddress});
            this.plAddress.Location = new System.Drawing.Point(0, 175);
            this.plAddress.Name = "plAddress";
            this.plAddress.Size = new System.Drawing.Size(300, 35);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(80, 35);
            this.label5.Text = "地址";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtAddress.Location = new System.Drawing.Point(80, 0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.txtAddress.Size = new System.Drawing.Size(220, 35);
            this.txtAddress.TouchLeave += new System.EventHandler(this.txtLocation_TouchLeave);
            // 
            // plBirthday
            // 
            this.plBirthday.BackColor = System.Drawing.Color.White;
            this.plBirthday.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plBirthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plBirthday.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.dpkBirthday});
            this.plBirthday.Location = new System.Drawing.Point(0, 210);
            this.plBirthday.Name = "plBirthday";
            this.plBirthday.Size = new System.Drawing.Size(300, 35);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(80, 35);
            this.label4.Text = "出生日期";
            // 
            // dpkBirthday
            // 
            this.dpkBirthday.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.dpkBirthday.Location = new System.Drawing.Point(80, 0);
            this.dpkBirthday.Name = "dpkBirthday";
            this.dpkBirthday.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.dpkBirthday.Size = new System.Drawing.Size(220, 35);
            this.dpkBirthday.ValueChanged += new System.EventHandler(this.dpkBirthday_ValueChanged);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(0, 245);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(300, 30);
            // 
            // plUser
            // 
            this.plUser.BackColor = System.Drawing.Color.White;
            this.plUser.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plUser.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label7,
            this.lblID});
            this.plUser.Location = new System.Drawing.Point(0, 275);
            this.plUser.Name = "plUser";
            this.plUser.Size = new System.Drawing.Size(300, 35);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(80, 40);
            this.label7.Text = "账号";
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(145)))));
            this.lblID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblID.Location = new System.Drawing.Point(80, 0);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblID.Size = new System.Drawing.Size(220, 40);
            // 
            // plTel
            // 
            this.plTel.BackColor = System.Drawing.Color.White;
            this.plTel.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plTel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label2,
            this.lblPhone});
            this.plTel.Location = new System.Drawing.Point(0, 310);
            this.plTel.Name = "plTel";
            this.plTel.Size = new System.Drawing.Size(300, 35);
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.Label2.Name = "Label2";
            this.Label2.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label2.Size = new System.Drawing.Size(80, 35);
            this.Label2.Text = "电话";
            // 
            // lblPhone
            // 
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(145)))));
            this.lblPhone.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblPhone.Location = new System.Drawing.Point(80, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblPhone.Size = new System.Drawing.Size(220, 40);
            // 
            // plEmail
            // 
            this.plEmail.BackColor = System.Drawing.Color.White;
            this.plEmail.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plEmail.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.lblEmail});
            this.plEmail.Location = new System.Drawing.Point(0, 345);
            this.plEmail.Name = "plEmail";
            this.plEmail.Size = new System.Drawing.Size(300, 35);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(59)))), ((int)(((byte)(106)))));
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(80, 40);
            this.label3.Text = "邮箱";
            // 
            // lblEmail
            // 
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(145)))));
            this.lblEmail.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.lblEmail.Location = new System.Drawing.Point(80, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 10F, 0F);
            this.lblEmail.Size = new System.Drawing.Size(220, 40);
            // 
            // frmUser
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Size = new System.Drawing.Size(300, 0);
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.Name = "frmUser";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        internal Smobiler.Core.Controls.Panel plImage;
        internal Smobiler.Core.Controls.Label lblName;
        internal Smobiler.Core.Controls.ImageButton imgEdit;
        internal Smobiler.Core.Controls.Panel plSex;
        private Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Button btnSex;
        internal Smobiler.Core.Controls.Panel plAddress;
        private Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.TextBox txtAddress;
        internal Smobiler.Core.Controls.Panel plBirthday;
        private Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.DatePicker dpkBirthday;
        private Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Panel plUser;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label lblID;
        internal Smobiler.Core.Controls.Panel plTel;
        private Smobiler.Core.Controls.Label Label2;
        private Smobiler.Core.Controls.Label lblPhone;
        internal Smobiler.Core.Controls.Panel plEmail;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lblEmail;
        private Smobiler.Core.Controls.Image image1;
    }
}