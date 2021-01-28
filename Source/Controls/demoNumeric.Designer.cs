using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Controls
{
    partial class demoNumeric : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.numeric1 = new Smobiler.Core.Controls.Numeric();
            this.numeric2 = new Smobiler.Core.Controls.Numeric();
            this.numeric3 = new Smobiler.Core.Controls.Numeric();
            this.numeric4 = new Smobiler.Core.Controls.Numeric();
            this.numeric5 = new Smobiler.Core.Controls.Numeric();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Numeric";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
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
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.numeric1,
            this.numeric2,
            this.numeric3,
            this.numeric4,
            this.numeric5});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 427);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "数量控件,不同样式的数量控件";
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
            this.labTitle.Text = "Numeric控件";
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 35);
            this.label1.Text = "FontSize属性可设置字体大小：\r\n";
            // 
            // label2
            // 
            this.label2.FontSize = 15F;
            this.label2.Location = new System.Drawing.Point(0, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 35);
            this.label2.Text = "IconVisible属性可设置是否显示加减图标：";
            // 
            // label3
            // 
            this.label3.FontSize = 15F;
            this.label3.Location = new System.Drawing.Point(0, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 35);
            this.label3.Text = "PlusIconColor、MinusIconColor属性可设置加号、减号图标字体颜色：\r\n";
            // 
            // label4
            // 
            this.label4.FontSize = 14F;
            this.label4.Location = new System.Drawing.Point(0, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 48);
            this.label4.Text = "MaxValue、MinValue、Value、Variation可设置数量控件可设置的最大值、最小值、显示的默认值、值变化时的增量";
            // 
            // numeric1
            // 
            this.numeric1.Location = new System.Drawing.Point(0, 121);
            this.numeric1.Name = "numeric1";
            this.numeric1.Size = new System.Drawing.Size(168, 25);
            // 
            // numeric2
            // 
            this.numeric2.FontSize = 13F;
            this.numeric2.Location = new System.Drawing.Point(0, 156);
            this.numeric2.Name = "numeric2";
            this.numeric2.Size = new System.Drawing.Size(168, 25);
            // 
            // numeric3
            // 
            this.numeric3.IconVisible = false;
            this.numeric3.Location = new System.Drawing.Point(0, 227);
            this.numeric3.Name = "numeric3";
            this.numeric3.Size = new System.Drawing.Size(168, 25);
            // 
            // numeric4
            // 
            this.numeric4.Location = new System.Drawing.Point(0, 305);
            this.numeric4.MinusIconColor = System.Drawing.Color.Lime;
            this.numeric4.Name = "numeric4";
            this.numeric4.PlusIconColor = System.Drawing.Color.Red;
            this.numeric4.Size = new System.Drawing.Size(168, 25);
            // 
            // numeric5
            // 
            this.numeric5.Location = new System.Drawing.Point(0, 391);
            this.numeric5.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric5.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeric5.Name = "numeric5";
            this.numeric5.Size = new System.Drawing.Size(168, 28);
            this.numeric5.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeric5.Variation = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // demoNumeric
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoNumeric";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
        private Core.Controls.Numeric numeric1;
        private Core.Controls.Numeric numeric2;
        private Core.Controls.Numeric numeric3;
        private Core.Controls.Numeric numeric4;
        private Core.Controls.Numeric numeric5;
    }
}