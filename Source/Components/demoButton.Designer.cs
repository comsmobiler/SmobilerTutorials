using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoButton : Smobiler.Core.Controls.MobileForm
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
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnRectangle = new Smobiler.Core.Controls.Button();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnCircle = new Smobiler.Core.Controls.Button();
            this.btnEclipse = new Smobiler.Core.Controls.Button();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnPress = new Smobiler.Core.Controls.Button();
            this.btnLongPress = new Smobiler.Core.Controls.Button();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Button";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
            this.panel5.Flex = 1;
            this.panel5.Name = "panel5";
            this.panel5.Scrollable = true;
            this.panel5.Size = new System.Drawing.Size(0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.BorderRadius = 5;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnRectangle,
            this.labContent,
            this.labTitle,
            this.label3,
            this.btnCircle,
            this.btnEclipse});
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 321);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btnRectangle.BorderColor = System.Drawing.Color.White;
            this.btnRectangle.BorderRadius = 0;
            this.btnRectangle.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dashed;
            this.btnRectangle.FontSize = 15F;
            this.btnRectangle.Location = new System.Drawing.Point(40, 110);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(224, 30);
            this.btnRectangle.Text = "方形按钮";
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 39);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 61);
            this.labContent.Text = "按钮控件，最常用的控件，用于触发一个点击事件，按钮控件也可以显示如下不同的样式。通过设置BackColor(背景颜色)、BorderColor（边框颜色）、Siz" +
    "e(控件大小)、Text（文本）创建不同样式的按钮";
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labTitle.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.labTitle.FontSize = 16F;
            this.labTitle.Location = new System.Drawing.Point(0, 1);
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labTitle.Size = new System.Drawing.Size(290, 36);
            this.labTitle.Text = "不同样式的按钮";
            // 
            // label3
            // 
            this.label3.FontSize = 14F;
            this.label3.Location = new System.Drawing.Point(0, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 60);
            this.label3.Text = "通过设置BorderRadius，使得button显示圆角，当BorderRadius等于button.Height等于button.Width时，button呈" +
    "圆形。";
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.btnCircle.Border = new Smobiler.Core.Controls.Border(5F);
            this.btnCircle.BorderColor = System.Drawing.Color.White;
            this.btnCircle.BorderRadius = 50;
            this.btnCircle.FontSize = 18F;
            this.btnCircle.ForeColor = System.Drawing.Color.OldLace;
            this.btnCircle.Location = new System.Drawing.Point(181, 214);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(80, 80);
            this.btnCircle.Text = "圆形按钮";
            // 
            // btnEclipse
            // 
            this.btnEclipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(99)))));
            this.btnEclipse.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dotted;
            this.btnEclipse.FontSize = 15F;
            this.btnEclipse.Location = new System.Drawing.Point(22, 227);
            this.btnEclipse.Name = "btnEclipse";
            this.btnEclipse.Size = new System.Drawing.Size(100, 38);
            this.btnEclipse.Text = "椭圆形按钮";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.btnPress,
            this.btnLongPress});
            this.panel2.Location = new System.Drawing.Point(5, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 141);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 44);
            this.label1.Text = "按钮控件有Press（点击）和LongPress（长按）两个事件，点击下面两个按钮试一下";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.FontSize = 16F;
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label2.Size = new System.Drawing.Size(290, 26);
            this.label2.Text = "按钮的事件";
            // 
            // btnPress
            // 
            this.btnPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btnPress.Location = new System.Drawing.Point(8, 80);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(100, 30);
            this.btnPress.Text = "点击我";
            this.btnPress.Press += new System.EventHandler(this.btnPress_Press);
            // 
            // btnLongPress
            // 
            this.btnLongPress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnLongPress.Location = new System.Drawing.Point(184, 81);
            this.btnLongPress.Name = "btnLongPress";
            this.btnLongPress.Size = new System.Drawing.Size(100, 30);
            this.btnLongPress.Text = "长按我";
            this.btnLongPress.LongPress += new System.EventHandler(this.btnLongPress_LongPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.spinner1,
            this.button1});
            this.panel3.Location = new System.Drawing.Point(5, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 123);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label4.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.FontSize = 16F;
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label4.Size = new System.Drawing.Size(290, 26);
            this.label4.Text = "基础属性";
            // 
            // spinner1
            // 
            this.spinner1.Items = new string[] {
        "FontSize - 13",
        "FontSize - 20",
        "ForeColor - Red",
        "ForeColor - Yellow",
        "Text - CurrentDate",
        "HorizontalAlignment - Left",
        "HorizontalAlignment - Center",
        "HorizontalAlignment - Right",
        "Shadow"};
            this.spinner1.Location = new System.Drawing.Point(0, 80);
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(290, 30);
            this.spinner1.Text = "FontSize - 13";
            this.spinner1.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner1_ItemSelected);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.button1.Location = new System.Drawing.Point(22, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 34);
            this.button1.Text = "button1";
            // 
            // demoButton
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel5});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoButton";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel5;
        private Core.Controls.Panel panel1;
        public Core.Controls.Button btnRectangle;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Label label3;
        private Core.Controls.Button btnCircle;
        private Core.Controls.Button btnEclipse;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Button btnPress;
        private Core.Controls.Button btnLongPress;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label4;
        private Core.Controls.Spinner spinner1;
        private Core.Controls.Button button1;
    }
}