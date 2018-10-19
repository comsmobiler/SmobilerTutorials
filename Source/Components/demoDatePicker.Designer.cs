using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoDatePicker : Smobiler.Core.Controls.MobileForm
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
            this.datePicker1 = new Smobiler.Core.Controls.DatePicker();
            this.datePicker2 = new Smobiler.Core.Controls.DatePicker();
            this.datePicker3 = new Smobiler.Core.Controls.DatePicker();
            this.datePicker4 = new Smobiler.Core.Controls.DatePicker();
            this.datePicker5 = new Smobiler.Core.Controls.DatePicker();
            this.datePicker6 = new Smobiler.Core.Controls.DatePicker();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.datePicker7 = new Smobiler.Core.Controls.DatePicker();
            this.datePicker8 = new Smobiler.Core.Controls.DatePicker();
            this.datePicker9 = new Smobiler.Core.Controls.DatePicker();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.datePicker10 = new Smobiler.Core.Controls.DatePicker();
            this.datePicker11 = new Smobiler.Core.Controls.DatePicker();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnShow = new Smobiler.Core.Controls.Button();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.datePicker12 = new Smobiler.Core.Controls.DatePicker();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "DatePicker";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5});
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
            this.datePicker1,
            this.datePicker2,
            this.datePicker3,
            this.datePicker4,
            this.datePicker5,
            this.datePicker6});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 212);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "日期选择控件，基础控件，Value、Mode、MinDate、MaxDate、ForeColor、FontSize、HorizontalAlignment属性设置" +
    "不同的样式\r\n";
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
            this.labTitle.Text = "不同样式的日期选择控件";
            // 
            // datePicker1
            // 
            this.datePicker1.Location = new System.Drawing.Point(25, 87);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(100, 30);
            // 
            // datePicker2
            // 
            this.datePicker2.Location = new System.Drawing.Point(25, 125);
            this.datePicker2.Mode = Smobiler.Core.Controls.DatePickerMode.DateTime;
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(100, 30);
            // 
            // datePicker3
            // 
            this.datePicker3.Location = new System.Drawing.Point(25, 165);
            this.datePicker3.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.datePicker3.Name = "datePicker3";
            this.datePicker3.Size = new System.Drawing.Size(100, 30);
            // 
            // datePicker4
            // 
            this.datePicker4.FontSize = 16F;
            this.datePicker4.Location = new System.Drawing.Point(165, 87);
            this.datePicker4.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.datePicker4.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.datePicker4.Name = "datePicker4";
            this.datePicker4.Size = new System.Drawing.Size(100, 30);
            // 
            // datePicker5
            // 
            this.datePicker5.FontSize = 11F;
            this.datePicker5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.datePicker5.Location = new System.Drawing.Point(165, 125);
            this.datePicker5.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.datePicker5.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.datePicker5.Mode = Smobiler.Core.Controls.DatePickerMode.DateTime;
            this.datePicker5.Name = "datePicker5";
            this.datePicker5.Size = new System.Drawing.Size(100, 30);
            // 
            // datePicker6
            // 
            this.datePicker6.FontSize = 16F;
            this.datePicker6.ForeColor = System.Drawing.Color.Red;
            this.datePicker6.Location = new System.Drawing.Point(165, 165);
            this.datePicker6.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.datePicker6.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.datePicker6.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.datePicker6.Name = "datePicker6";
            this.datePicker6.Size = new System.Drawing.Size(100, 30);
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
            this.datePicker7,
            this.datePicker8,
            this.datePicker9});
            this.panel2.Location = new System.Drawing.Point(5, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 207);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(0, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 54);
            this.label5.Text = "Mode设置日期/时间模式，Time(仅时间),Date(仅日期),DateTime(日期和时间)";
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
            this.label6.Text = "日期选择控件的日期、时间模式";
            // 
            // datePicker7
            // 
            this.datePicker7.Location = new System.Drawing.Point(95, 91);
            this.datePicker7.Mode = Smobiler.Core.Controls.DatePickerMode.Time;
            this.datePicker7.Name = "datePicker7";
            this.datePicker7.Size = new System.Drawing.Size(100, 30);
            // 
            // datePicker8
            // 
            this.datePicker8.Location = new System.Drawing.Point(95, 129);
            this.datePicker8.Name = "datePicker8";
            this.datePicker8.Size = new System.Drawing.Size(100, 30);
            // 
            // datePicker9
            // 
            this.datePicker9.Location = new System.Drawing.Point(95, 169);
            this.datePicker9.Mode = Smobiler.Core.Controls.DatePickerMode.DateTime;
            this.datePicker9.Name = "datePicker9";
            this.datePicker9.Size = new System.Drawing.Size(100, 30);
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
            this.datePicker10,
            this.datePicker11});
            this.panel3.Location = new System.Drawing.Point(5, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 151);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(0, 26);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label13.Size = new System.Drawing.Size(290, 54);
            this.label13.Text = "Enabled属性指示是否已启用该控件";
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
            this.label14.Text = "是否启用日期选择控件";
            // 
            // datePicker10
            // 
            this.datePicker10.Location = new System.Drawing.Point(33, 101);
            this.datePicker10.Name = "datePicker10";
            this.datePicker10.Size = new System.Drawing.Size(100, 30);
            // 
            // datePicker11
            // 
            this.datePicker11.Enabled = false;
            this.datePicker11.Location = new System.Drawing.Point(167, 101);
            this.datePicker11.Name = "datePicker11";
            this.datePicker11.Size = new System.Drawing.Size(100, 30);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.Silver;
            this.panel4.BorderRadius = 5;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.btnShow});
            this.panel4.Location = new System.Drawing.Point(5, 623);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 153);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 54);
            this.label1.Text = "Show显示选择时间/日期的界面";
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
            this.label2.Text = "日期选择控件方法";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(93, 103);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 30);
            this.btnShow.Text = "Show";
            this.btnShow.Press += new System.EventHandler(this.btnShow_Press);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.Silver;
            this.panel5.BorderRadius = 5;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.label4,
            this.datePicker12});
            this.panel5.Location = new System.Drawing.Point(5, 791);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 153);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 26);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label3.Size = new System.Drawing.Size(290, 54);
            this.label3.Text = "ValueChanged在日期/时间选择时发生";
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
            this.label4.Text = "日期选择控件事件";
            // 
            // datePicker12
            // 
            this.datePicker12.Location = new System.Drawing.Point(95, 99);
            this.datePicker12.Name = "datePicker12";
            this.datePicker12.Size = new System.Drawing.Size(100, 30);
            this.datePicker12.ValueChanged += new System.EventHandler(this.datePicker12_ValueChanged);
            // 
            // demoDatePicker
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoDatePicker";

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
        private Core.Controls.DatePicker datePicker4;
        private Core.Controls.DatePicker datePicker5;
        private Core.Controls.DatePicker datePicker6;
        private Core.Controls.DatePicker datePicker1;
        private Core.Controls.DatePicker datePicker2;
        private Core.Controls.DatePicker datePicker3;
        private Core.Controls.DatePicker datePicker7;
        private Core.Controls.DatePicker datePicker8;
        private Core.Controls.DatePicker datePicker9;
        private Core.Controls.Label label14;
        private Core.Controls.Panel panel4;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label13;
        private Core.Controls.DatePicker datePicker10;
        private Core.Controls.DatePicker datePicker11;
        private Core.Controls.Button btnShow;
        private Core.Controls.Panel panel5;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
        private Core.Controls.DatePicker datePicker12;
    }
}