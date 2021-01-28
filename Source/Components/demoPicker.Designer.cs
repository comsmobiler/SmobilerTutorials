using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoPicker : Smobiler.Core.Controls.MobileForm
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
            this.picker1 = new Smobiler.Core.Controls.Picker();
            this.picker2 = new Smobiler.Core.Controls.Picker();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.picker3 = new Smobiler.Core.Controls.Picker();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Picker";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2});
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
            this.picker1,
            this.picker2});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 179);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "元素选择控件，基础控件，FontSize、ForeColor、SelectedForeColor、SelectedIndex\r\n设置元素选择控件样式\r\n";
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
            this.labTitle.Text = "不同样式的元素选择控件";
            // 
            // picker1
            // 
            this.picker1.FontSize = 15F;
            this.picker1.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6"};
            this.picker1.Location = new System.Drawing.Point(0, 80);
            this.picker1.Name = "picker1";
            this.picker1.Size = new System.Drawing.Size(140, 98);
            // 
            // picker2
            // 
            this.picker2.FontSize = 16F;
            this.picker2.ForeColor = System.Drawing.Color.LightGray;
            this.picker2.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5"};
            this.picker2.Location = new System.Drawing.Point(150, 80);
            this.picker2.Name = "picker2";
            this.picker2.SelectedForeColor = System.Drawing.Color.Red;
            this.picker2.SelectedIndex = 1;
            this.picker2.Size = new System.Drawing.Size(140, 98);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label13,
            this.label14,
            this.picker3});
            this.panel2.Location = new System.Drawing.Point(5, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 235);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.FontSize = 15F;
            this.label13.Location = new System.Drawing.Point(0, 26);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label13.Size = new System.Drawing.Size(290, 54);
            this.label13.Text = "SelectedIndexChanged当选择索引改变时触发。";
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
            this.label14.Text = "元素选择控件事件";
            // 
            // picker3
            // 
            this.picker3.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5"};
            this.picker3.Location = new System.Drawing.Point(43, 80);
            this.picker3.Name = "picker3";
            this.picker3.Size = new System.Drawing.Size(200, 151);
            this.picker3.SelectedIndexChanged += new System.EventHandler(this.picker3_SelectedIndexChanged);
            // 
            // demoPicker
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoPicker";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label13;
        private Core.Controls.Picker picker1;
        private Core.Controls.Picker picker2;
        private Core.Controls.Label label14;
        private Core.Controls.Picker picker3;
    }
}