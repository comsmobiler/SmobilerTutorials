using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoArcFace : Smobiler.Core.Controls.MobileForm
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
            this.arcFace1 = new Smobiler.Plugins.ArcFace();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.btnregisterFace = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnrecognitionFace = new Smobiler.Core.Controls.Button();
            this.btnexistFace = new Smobiler.Core.Controls.Button();
            this.btndeleteFace = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // arcFace1
            // 
            this.arcFace1.Name = "arcFace1";
            this.arcFace1.FacialRecognized += new Smobiler.Plugins.FacialRecognizedEventHandler(this.arcFace1_FacialRecognized);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ArcFace";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.label3,
            this.label7,
            this.label8,
            this.label9,
            this.btnregisterFace,
            this.textBox1,
            this.label2,
            this.btnrecognitionFace,
            this.btnexistFace,
            this.btndeleteFace,
            this.label1});
            this.panel2.Location = new System.Drawing.Point(5, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 716);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 45);
            this.labContent.Text = "使用方法：1.注册人脸 2. 识别人脸信息\r\n\r\n\r\n";
            this.labContent.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labTitle.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.labTitle.FontSize = 16F;
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labTitle.Size = new System.Drawing.Size(290, 26);
            this.labTitle.Text = "人脸识别";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.FontSize = 16F;
            this.label3.Location = new System.Drawing.Point(0, 85);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label3.Size = new System.Drawing.Size(290, 26);
            this.label3.Text = "注册";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label7.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.FontSize = 16F;
            this.label7.Location = new System.Drawing.Point(0, 250);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label7.Size = new System.Drawing.Size(290, 26);
            this.label7.Text = "识别";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label8.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.FontSize = 16F;
            this.label8.Location = new System.Drawing.Point(0, 356);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label8.Size = new System.Drawing.Size(290, 26);
            this.label8.Text = "其他";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 821);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 68);
            // 
            // btnregisterFace
            // 
            this.btnregisterFace.Location = new System.Drawing.Point(54, 179);
            this.btnregisterFace.Name = "btnregisterFace";
            this.btnregisterFace.Size = new System.Drawing.Size(186, 30);
            this.btnregisterFace.Text = "注册";
            this.btnregisterFace.Press += new System.EventHandler(this.btnregisterFace_Press);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 35);
            // 
            // label2
            // 
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(18, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 35);
            this.label2.Text = "name";
            // 
            // btnrecognitionFace
            // 
            this.btnrecognitionFace.Location = new System.Drawing.Point(59, 298);
            this.btnrecognitionFace.Name = "btnrecognitionFace";
            this.btnrecognitionFace.Size = new System.Drawing.Size(186, 30);
            this.btnrecognitionFace.Text = "识别";
            this.btnrecognitionFace.Press += new System.EventHandler(this.btnrecognitionFace_Press);
            // 
            // btnexistFace
            // 
            this.btnexistFace.Location = new System.Drawing.Point(59, 406);
            this.btnexistFace.Name = "btnexistFace";
            this.btnexistFace.Size = new System.Drawing.Size(186, 30);
            this.btnexistFace.Text = "判断";
            this.btnexistFace.Press += new System.EventHandler(this.btnexistFace_Press);
            // 
            // btndeleteFace
            // 
            this.btndeleteFace.Location = new System.Drawing.Point(59, 457);
            this.btndeleteFace.Name = "btndeleteFace";
            this.btndeleteFace.Size = new System.Drawing.Size(186, 30);
            this.btndeleteFace.Text = "删除";
            this.btndeleteFace.Press += new System.EventHandler(this.btndeleteFace_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 204);
            // 
            // demoArcFace
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.arcFace1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoArcFace";

        }
        #endregion
        private Smobiler.Plugins.ArcFace arcFace1;
        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label labContent;
        private Smobiler.Core.Controls.Label labTitle;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Button btnregisterFace;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Button btnrecognitionFace;
        private Smobiler.Core.Controls.Button btnexistFace;
        private Smobiler.Core.Controls.Button btndeleteFace;
        private Smobiler.Core.Controls.Label label1;
    }
}