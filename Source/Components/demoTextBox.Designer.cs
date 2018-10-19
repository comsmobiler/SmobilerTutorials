using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoTextBox : Smobiler.Core.Controls.MobileForm
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
            this.panel10 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.textBox3 = new Smobiler.Core.Controls.TextBox();
            this.textBox4 = new Smobiler.Core.Controls.TextBox();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.textBox5 = new Smobiler.Core.Controls.TextBox();
            this.textBox6 = new Smobiler.Core.Controls.TextBox();
            this.textBox7 = new Smobiler.Core.Controls.TextBox();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.textBox8 = new Smobiler.Core.Controls.TextBox();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label16 = new Smobiler.Core.Controls.Label();
            this.label17 = new Smobiler.Core.Controls.Label();
            this.textBox9 = new Smobiler.Core.Controls.TextBox();
            this.textBox10 = new Smobiler.Core.Controls.TextBox();
            this.textBox11 = new Smobiler.Core.Controls.TextBox();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.textBox12 = new Smobiler.Core.Controls.TextBox();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.textBox13 = new Smobiler.Core.Controls.TextBox();
            this.textBox14 = new Smobiler.Core.Controls.TextBox();
            this.textBox15 = new Smobiler.Core.Controls.TextBox();
            this.textBox16 = new Smobiler.Core.Controls.TextBox();
            this.textBox17 = new Smobiler.Core.Controls.TextBox();
            this.textBox18 = new Smobiler.Core.Controls.TextBox();
            this.panel7 = new Smobiler.Core.Controls.Panel();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.textBoxFocusOrBlur = new Smobiler.Core.Controls.TextBox();
            this.btnFocus = new Smobiler.Core.Controls.Button();
            this.btnBlur = new Smobiler.Core.Controls.Button();
            this.panel8 = new Smobiler.Core.Controls.Panel();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.textBox19 = new Smobiler.Core.Controls.TextBox();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "TextBox";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5,
            this.panel6,
            this.panel7,
            this.panel8});
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 30);
            this.panel10.Name = "panel10";
            this.panel10.Scrollable = true;
            this.panel10.Size = new System.Drawing.Size(300, 970);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.BorderRadius = 5;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 179);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "文本框控件，最常用的控件，用于显示文本内容，可以显示如下不同的样式。可以调整字体，颜色等属性";
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
            this.labTitle.Text = "不同样式的文本框";
            // 
            // textBox1
            // 
            this.textBox1.FontSize = 16F;
            this.textBox1.Location = new System.Drawing.Point(27, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.Text = "字体大小";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(161, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 35);
            this.textBox2.Text = "字体颜色";
            // 
            // textBox3
            // 
            this.textBox3.Bold = true;
            this.textBox3.Italic = true;
            this.textBox3.Location = new System.Drawing.Point(27, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 35);
            this.textBox3.Text = "粗体斜体";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 35);
            this.textBox4.Text = "文本框只读";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.label6,
            this.textBox5,
            this.textBox6,
            this.textBox7});
            this.panel2.Location = new System.Drawing.Point(5, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 219);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(0, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 54);
            this.label5.Text = "HorizontalAlignment属性设置文字水平显示位置";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label6.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.FontSize = 16F;
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label6.Size = new System.Drawing.Size(290, 26);
            this.label6.Text = "文本框水平位置";
            // 
            // textBox5
            // 
            this.textBox5.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox5.BorderColor = System.Drawing.Color.Gainsboro;
            this.textBox5.Location = new System.Drawing.Point(19, 87);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(244, 30);
            this.textBox5.Text = "水平居左";
            // 
            // textBox6
            // 
            this.textBox6.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox6.BorderColor = System.Drawing.Color.Gainsboro;
            this.textBox6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.textBox6.Location = new System.Drawing.Point(19, 130);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(244, 30);
            this.textBox6.Text = "水平居中";
            // 
            // textBox7
            // 
            this.textBox7.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox7.BorderColor = System.Drawing.Color.Gainsboro;
            this.textBox7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox7.Location = new System.Drawing.Point(19, 173);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(244, 30);
            this.textBox7.Text = "水平居右";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label13,
            this.label14,
            this.textBox8});
            this.panel3.Location = new System.Drawing.Point(5, 437);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 131);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(0, 26);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label13.Size = new System.Drawing.Size(290, 54);
            this.label13.Text = "SecurityMode属性可设置密文显示\r\n";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label14.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label14.FontSize = 16F;
            this.label14.Name = "label14";
            this.label14.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label14.Size = new System.Drawing.Size(290, 26);
            this.label14.Text = "文本框密文";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(23, 91);
            this.textBox8.Name = "textBox8";
            this.textBox8.SecurityMode = true;
            this.textBox8.Size = new System.Drawing.Size(238, 27);
            this.textBox8.Text = "密文模式文本";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.Silver;
            this.panel4.BorderRadius = 5;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label16,
            this.label17,
            this.textBox9,
            this.textBox10,
            this.textBox11});
            this.panel4.Location = new System.Drawing.Point(5, 585);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 195);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(0, 26);
            this.label16.Name = "label16";
            this.label16.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label16.Size = new System.Drawing.Size(290, 54);
            this.label16.Text = "Multiline、MaxLength属性可设置允许显示的行数或字符数\r\n";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label17.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label17.FontSize = 16F;
            this.label17.Name = "label17";
            this.label17.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label17.Size = new System.Drawing.Size(290, 26);
            this.label17.Text = "文本框允许显示的行数或字符数";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(15, 89);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(110, 45);
            this.textBox9.Text = "Multiline设置为true，可显示多行\r\n";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(153, 87);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(114, 47);
            this.textBox10.Text = "Multiline设置为flase，显示单行";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(19, 151);
            this.textBox11.MaxLength = 7;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(248, 35);
            this.textBox11.Text = "数数正好七个字";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.Silver;
            this.panel5.BorderRadius = 5;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.textBox12});
            this.panel5.Location = new System.Drawing.Point(5, 797);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 131);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 54);
            this.label1.Text = "WaterMarkText、WaterMarkTextColor属性可设置水印文字、水印颜色";
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
            this.label2.Text = "文本框水印";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(23, 91);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(238, 27);
            this.textBox12.WaterMarkText = "设置水印，可提示输入";
            this.textBox12.WaterMarkTextColor = System.Drawing.Color.Silver;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel6.BorderColor = System.Drawing.Color.Silver;
            this.panel6.BorderRadius = 5;
            this.panel6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.label4,
            this.textBox13,
            this.textBox14,
            this.textBox15,
            this.textBox16,
            this.textBox17,
            this.textBox18});
            this.panel6.Location = new System.Drawing.Point(5, 947);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 241);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 26);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label3.Size = new System.Drawing.Size(290, 54);
            this.label3.Text = "KeyboardType、ReturnKeyType属性可设置键盘模式、返回键外观";
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
            this.label4.Text = "文本框键盘模式";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(13, 89);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(120, 35);
            this.textBox13.Text = "Default:Default";
            // 
            // textBox14
            // 
            this.textBox14.KeyboardType = Smobiler.Core.Controls.KeyboardType.EmailAddress;
            this.textBox14.Location = new System.Drawing.Point(151, 89);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Done;
            this.textBox14.Size = new System.Drawing.Size(120, 35);
            this.textBox14.Text = "EmailAddress:Done";
            // 
            // textBox15
            // 
            this.textBox15.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox15.Location = new System.Drawing.Point(13, 141);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Go;
            this.textBox15.Size = new System.Drawing.Size(120, 35);
            this.textBox15.Text = "Numeric:Go";
            // 
            // textBox16
            // 
            this.textBox16.KeyboardType = Smobiler.Core.Controls.KeyboardType.PhonePad;
            this.textBox16.Location = new System.Drawing.Point(151, 141);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Next;
            this.textBox16.Size = new System.Drawing.Size(120, 35);
            this.textBox16.Text = "PhonePad:Next";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(13, 193);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Search;
            this.textBox17.Size = new System.Drawing.Size(120, 35);
            this.textBox17.Text = "Default:Search";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(151, 193);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReturnKeyType = Smobiler.Core.Controls.ReturnKeyType.Send;
            this.textBox18.Size = new System.Drawing.Size(120, 35);
            this.textBox18.Text = "Default:Send";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel7.BorderColor = System.Drawing.Color.Silver;
            this.panel7.BorderRadius = 5;
            this.panel7.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label7,
            this.label8,
            this.textBoxFocusOrBlur,
            this.btnFocus,
            this.btnBlur});
            this.panel7.Location = new System.Drawing.Point(5, 1209);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(290, 171);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(0, 26);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label7.Size = new System.Drawing.Size(290, 54);
            this.label7.Text = "Focus、Blur方法可使文本框获取、失去焦点";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label8.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label8.FontSize = 16F;
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label8.Size = new System.Drawing.Size(290, 26);
            this.label8.Text = "文本框焦点";
            // 
            // textBoxFocusOrBlur
            // 
            this.textBoxFocusOrBlur.Location = new System.Drawing.Point(23, 91);
            this.textBoxFocusOrBlur.Name = "textBoxFocusOrBlur";
            this.textBoxFocusOrBlur.Size = new System.Drawing.Size(238, 27);
            this.textBoxFocusOrBlur.Text = "点击下面按钮，使用获取、失去焦点";
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(23, 131);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(100, 30);
            this.btnFocus.Text = "获取焦点";
            this.btnFocus.Press += new System.EventHandler(this.btnFocus_Press);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(161, 131);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(100, 30);
            this.btnBlur.Text = "失去焦点";
            this.btnBlur.Press += new System.EventHandler(this.btnBlur_Press);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel8.BorderColor = System.Drawing.Color.Silver;
            this.panel8.BorderRadius = 5;
            this.panel8.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label9,
            this.label10,
            this.textBox19});
            this.panel8.Location = new System.Drawing.Point(5, 1399);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(290, 131);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(0, 26);
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label9.Size = new System.Drawing.Size(290, 54);
            this.label9.Text = "TextChanged（text属性改变时发生）、TouchEnter（在触摸进入控件时发生）、TouchLeave（在触摸离开控件时发生）事件";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label10.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label10.FontSize = 16F;
            this.label10.Name = "label10";
            this.label10.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label10.Size = new System.Drawing.Size(290, 26);
            this.label10.Text = "文本框事件";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(23, 91);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(238, 27);
            this.textBox19.Text = "修改文本内容、进入、离开触发事件";
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            this.textBox19.TouchEnter += new System.EventHandler(this.textBox19_TouchEnter);
            this.textBox19.TouchLeave += new System.EventHandler(this.textBox19_TouchLeave);
            // 
            // demoTextBox
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 2000);
            this.Name = "demoTextBox";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label5;
        private Core.Controls.Label label6;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label13;
        private Core.Controls.Label label14;
        private Core.Controls.Panel panel4;
        private Core.Controls.Label label16;
        private Core.Controls.Label label17;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.TextBox textBox2;
        private Core.Controls.TextBox textBox3;
        private Core.Controls.TextBox textBox4;
        private Core.Controls.TextBox textBox5;
        private Core.Controls.TextBox textBox6;
        private Core.Controls.TextBox textBox7;
        private Core.Controls.TextBox textBox8;
        private Core.Controls.TextBox textBox9;
        private Core.Controls.TextBox textBox10;
        private Core.Controls.TextBox textBox11;
        private Core.Controls.Panel panel5;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.TextBox textBox12;
        private Core.Controls.Panel panel6;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
        private Core.Controls.TextBox textBox13;
        private Core.Controls.TextBox textBox14;
        private Core.Controls.TextBox textBox15;
        private Core.Controls.TextBox textBox16;
        private Core.Controls.TextBox textBox17;
        private Core.Controls.TextBox textBox18;
        private Core.Controls.Panel panel7;
        private Core.Controls.Label label7;
        private Core.Controls.Label label8;
        private Core.Controls.TextBox textBoxFocusOrBlur;
        private Core.Controls.Button btnFocus;
        private Core.Controls.Button btnBlur;
        private Core.Controls.Panel panel8;
        private Core.Controls.Label label9;
        private Core.Controls.Label label10;
        private Core.Controls.TextBox textBox19;
    }
}