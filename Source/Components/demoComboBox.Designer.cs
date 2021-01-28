using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoComboBox : Smobiler.Core.Controls.MobileForm
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
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.comboBox1 = new Smobiler.Core.Controls.ComboBox();
            this.comboBox2 = new Smobiler.Core.Controls.ComboBox();
            this.comboBox3 = new Smobiler.Core.Controls.ComboBox();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ComboBox";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.panel3});
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
            this.comboBox1,
            this.comboBox2});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 179);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "下拉列表控件，基础控件,Text、FontSize、ForeColor属性设置不同样式";
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
            this.labTitle.Text = "不同样式的下拉列表控件";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.label6,
            this.comboBox3});
            this.panel3.Location = new System.Drawing.Point(5, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 171);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FontSize = 15F;
            this.label5.Location = new System.Drawing.Point(0, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 54);
            this.label5.Text = "ItemSelected在列表元素选择后发生";
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
            this.label6.Text = "下拉列表控件事件";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(11, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 30);
            this.comboBox1.Text = "item1";
            // 
            // comboBox2
            // 
            this.comboBox2.FontSize = 16F;
            this.comboBox2.ForeColor = System.Drawing.Color.Red;
            this.comboBox2.ItemFontSize = 16F;
            this.comboBox2.ItemForeColor = System.Drawing.Color.Red;
            this.comboBox2.Location = new System.Drawing.Point(146, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 30);
            this.comboBox2.Text = "item2";
            // 
            // comboBox3
            // 
            this.comboBox3.Location = new System.Drawing.Point(82, 103);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(120, 30);
            this.comboBox3.ItemSelected += new System.EventHandler(this.comboBox3_ItemSelected);
            // 
            // demoComboBox
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoComboBox_Load);
            this.Name = "demoComboBox";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.ComboBox comboBox1;
        private Core.Controls.ComboBox comboBox2;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label5;
        private Core.Controls.Label label6;
        private Core.Controls.ComboBox comboBox3;
    }
}