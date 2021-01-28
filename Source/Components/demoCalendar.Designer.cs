using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoCalendar : Smobiler.Core.Controls.MobileForm
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
            this.calendar1 = new Smobiler.Core.Controls.Calendar();
            this.calendar2 = new Smobiler.Core.Controls.Calendar();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.calendar3 = new Smobiler.Core.Controls.Calendar();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Calendar";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel3});
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
            this.calendar1,
            this.calendar2});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 575);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "日历控件，基础控件";
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
            this.labTitle.Text = "不同样式的日历控件";
            // 
            // calendar1
            // 
            this.calendar1.Location = new System.Drawing.Point(24, 92);
            this.calendar1.Name = "calendar1";
            this.calendar1.SelectDateBackColor = System.Drawing.Color.Peru;
            this.calendar1.Size = new System.Drawing.Size(240, 230);
            this.calendar1.WeekForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            // 
            // calendar2
            // 
            this.calendar2.DayForeColor = System.Drawing.Color.Blue;
            this.calendar2.DisabledDayForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.calendar2.Location = new System.Drawing.Point(24, 334);
            this.calendar2.Name = "calendar2";
            this.calendar2.SelectDateBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calendar2.SelectDateForeColor = System.Drawing.Color.DimGray;
            this.calendar2.Size = new System.Drawing.Size(240, 230);
            this.calendar2.TodayForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.calendar2.WeekForeColor = System.Drawing.Color.Blue;
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
            this.calendar3});
            this.panel3.Location = new System.Drawing.Point(5, 592);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 344);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.FontSize = 15F;
            this.label13.Location = new System.Drawing.Point(0, 26);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label13.Size = new System.Drawing.Size(290, 54);
            this.label13.Text = "DateChanged在选择日期时发生";
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
            this.label14.Text = "日历控件事件";
            // 
            // calendar3
            // 
            this.calendar3.Location = new System.Drawing.Point(24, 97);
            this.calendar3.Name = "calendar3";
            this.calendar3.Size = new System.Drawing.Size(240, 230);
            this.calendar3.DateChanged += new System.EventHandler(this.calendar3_DateChanged);
            // 
            // demoCalendar
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoCalendar";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label13;
        private Core.Controls.Label label14;
        private Core.Controls.Calendar calendar1;
        private Core.Controls.Calendar calendar2;
        private Core.Controls.Calendar calendar3;
    }
}