using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoCalenderStrip : Smobiler.Core.Controls.MobileForm
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
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.calenderStrip1 = new Smobiler.Plugins.CalenderStrip();
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Default;
            this.title1.Text = "CalenderStrip";
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
            this.calenderStrip1,
            this.spinner1});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 222);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.White;
            this.labContent.FontSize = 15F;
            this.labContent.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.labContent.Location = new System.Drawing.Point(0, 80);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 56);
            this.labContent.Text = "点击上方下拉框";
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
            this.labTitle.Text = "条形日历控件";
            // 
            // calenderStrip1
            // 
            this.calenderStrip1.DateNameColor = System.Drawing.Color.CornflowerBlue;
            this.calenderStrip1.DateNumberColor = System.Drawing.Color.CornflowerBlue;
            this.calenderStrip1.DaySelectionColor = System.Drawing.Color.CornflowerBlue;
            this.calenderStrip1.Location = new System.Drawing.Point(21, 150);
            this.calenderStrip1.Name = "calenderStrip1";
            this.calenderStrip1.Size = new System.Drawing.Size(238, 55);
            // 
            // spinner1
            // 
            this.spinner1.Items = new string[] {
        "DateNameColor",
        "DateNumberColor",
        "DaySelectionColor",
        "DaySelectionType",
        "DisabledDateNameColor",
        "DisabledDateNumberColor",
        "HighlightDateNameColor",
        "HighlightDateNumberColor",
        "IconColor",
        "MaxDate",
        "MinDate",
        "ShowDate",
        "ShowDayName",
        "ShowDayNumber",
        "ShowMonth"};
            this.spinner1.Location = new System.Drawing.Point(21, 38);
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(238, 30);
            this.spinner1.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner1_ItemSelected);
            // 
            // demoCalenderStrip
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoCalenderStrip";
            this.Name = "demoCalenderStrip";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Smobiler.Plugins.CalenderStrip calenderStrip1;
        private Core.Controls.Spinner spinner1;
    }
}