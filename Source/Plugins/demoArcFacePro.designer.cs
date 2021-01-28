using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoArcFacePro : Smobiler.Core.Controls.MobileForm
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
            this.btnactiveonline = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.btnregisterFace = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.btnrecognitionFace = new Smobiler.Core.Controls.Button();
            this.btnliveness = new Smobiler.Core.Controls.Button();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.btnexistFace = new Smobiler.Core.Controls.Button();
            this.btndeleteFace = new Smobiler.Core.Controls.Button();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnClear = new Smobiler.Core.Controls.Button();
            // 
            // arcFace1
            // 
            this.arcFace1.Name = "arcFace1";
            this.arcFace1.FacialRecognized += new Smobiler.Plugins.FacialRecognizedEventHandler(this.arcFace1_FacialRecognized);
            this.arcFace1.FacialRegistered += new Smobiler.Plugins.FacialRegisteredEventHandler(this.arcFace1_FacialRegistered);
            this.arcFace1.ImageCaptured += new Smobiler.Core.Controls.BinaryResultCallBackHandler(this.arcFace1_ImageCaptured);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ArcFacePro";
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
            this.btnactiveonline,
            this.label3,
            this.label4,
            this.btnregisterFace,
            this.textBox1,
            this.label2,
            this.label5,
            this.image1,
            this.btnrecognitionFace,
            this.btnliveness,
            this.label6,
            this.btnexistFace,
            this.btndeleteFace,
            this.label7,
            this.label1,
            this.btnClear});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 808);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 83);
            this.labContent.Text = "与arcface差别：arcfacepro 支持活体检测，在云平台上打包时需要打包arcfacepro插件\r\n使用方法：1.激活设备 2.注册人脸 3. 识别人脸" +
    "信息\r\n\r\n";
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
            // btnactiveonline
            // 
            this.btnactiveonline.Location = new System.Drawing.Point(51, 174);
            this.btnactiveonline.Name = "btnactiveonline";
            this.btnactiveonline.Size = new System.Drawing.Size(186, 30);
            this.btnactiveonline.Text = "激活设备";
            this.btnactiveonline.Press += new System.EventHandler(this.btnactiveonline_Press);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.FontSize = 16F;
            this.label3.Location = new System.Drawing.Point(0, 134);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label3.Size = new System.Drawing.Size(290, 26);
            this.label3.Text = "激活设备ActiveOnline";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label4.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.FontSize = 16F;
            this.label4.Location = new System.Drawing.Point(0, 229);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label4.Size = new System.Drawing.Size(290, 26);
            this.label4.Text = "注册人脸Register";
            // 
            // btnregisterFace
            // 
            this.btnregisterFace.Location = new System.Drawing.Point(51, 405);
            this.btnregisterFace.Name = "btnregisterFace";
            this.btnregisterFace.Size = new System.Drawing.Size(186, 30);
            this.btnregisterFace.Text = "注册";
            this.btnregisterFace.Press += new System.EventHandler(this.btnregisterFace_Press);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 35);
            // 
            // label2
            // 
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(5, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 35);
            this.label2.Text = "name";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FontSize = 15F;
            this.label5.Location = new System.Drawing.Point(0, 256);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 70);
            this.label5.Text = "在下方textbox输入name，点击注册，ImageCaptured事件在注册人脸后返回图片；之后就可以进行识别";
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(95, 452);
            this.image1.Name = "image1";
            this.image1.ResourcePath = "upload";
            this.image1.Size = new System.Drawing.Size(75, 85);
            // 
            // btnrecognitionFace
            // 
            this.btnrecognitionFace.Location = new System.Drawing.Point(51, 595);
            this.btnrecognitionFace.Name = "btnrecognitionFace";
            this.btnrecognitionFace.Size = new System.Drawing.Size(80, 30);
            this.btnrecognitionFace.Text = "普通识别";
            this.btnrecognitionFace.Press += new System.EventHandler(this.btnrecognitionFace_Press);
            // 
            // btnliveness
            // 
            this.btnliveness.Location = new System.Drawing.Point(157, 595);
            this.btnliveness.Name = "btnliveness";
            this.btnliveness.Size = new System.Drawing.Size(80, 30);
            this.btnliveness.Text = "活体检测";
            this.btnliveness.Press += new System.EventHandler(this.btnliveness_Press);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label6.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.FontSize = 16F;
            this.label6.Location = new System.Drawing.Point(0, 554);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label6.Size = new System.Drawing.Size(290, 26);
            this.label6.Text = "识别";
            // 
            // btnexistFace
            // 
            this.btnexistFace.Location = new System.Drawing.Point(23, 708);
            this.btnexistFace.Name = "btnexistFace";
            this.btnexistFace.Size = new System.Drawing.Size(101, 30);
            this.btnexistFace.Text = "判断人脸是否存在";
            this.btnexistFace.Press += new System.EventHandler(this.btnexistFace_Press);
            // 
            // btndeleteFace
            // 
            this.btndeleteFace.Location = new System.Drawing.Point(156, 708);
            this.btndeleteFace.Name = "btndeleteFace";
            this.btndeleteFace.Size = new System.Drawing.Size(105, 30);
            this.btndeleteFace.Text = "删除人脸";
            this.btndeleteFace.Press += new System.EventHandler(this.btndeleteFace_Press);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label7.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.FontSize = 16F;
            this.label7.Location = new System.Drawing.Point(0, 660);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label7.Size = new System.Drawing.Size(290, 26);
            this.label7.Text = "其他";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 821);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 68);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(57, 758);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(178, 30);
            this.btnClear.Text = "Clear清除客户端人脸信息";
            this.btnClear.Press += new System.EventHandler(this.btnClear_Press);
            // 
            // demoArcFacePro
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.arcFace1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(300, 1500);
            this.Name = "demoArcFacePro";

        }
        #endregion

        private Smobiler.Plugins.ArcFace arcFace1;
        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Label labContent;
        private Smobiler.Core.Controls.Label labTitle;
        private Smobiler.Core.Controls.Button btnactiveonline;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Button btnregisterFace;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Button btnrecognitionFace;
        private Smobiler.Core.Controls.Button btnliveness;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Button btnexistFace;
        private Smobiler.Core.Controls.Button btndeleteFace;
        private Smobiler.Core.Controls.Label label7;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button btnClear;
    }
}