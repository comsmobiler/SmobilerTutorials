using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoCheckBox : Smobiler.Core.Controls.MobileForm
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
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            this.checkBox2 = new Smobiler.Core.Controls.CheckBox();
            this.checkBox3 = new Smobiler.Core.Controls.CheckBox();
            this.checkBox4 = new Smobiler.Core.Controls.CheckBox();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.checkBox5 = new Smobiler.Core.Controls.CheckBox();
            this.checkBox6 = new Smobiler.Core.Controls.CheckBox();
            this.checkBox7 = new Smobiler.Core.Controls.CheckBox();
            this.checkBox8 = new Smobiler.Core.Controls.CheckBox();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.checkBox9 = new Smobiler.Core.Controls.CheckBox();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "CheckBox";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
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
            this.checkBox1,
            this.checkBox2,
            this.checkBox3,
            this.checkBox4});
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
            this.labContent.Text = "复选框控件，基础控件，Checked、TintColor、Style设置复选框样式";
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
            this.labTitle.Text = "不同样式的复选框";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(45, 119);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 22);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.Location = new System.Drawing.Point(99, 119);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(22, 22);
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(157, 119);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(22, 22);
            this.checkBox3.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.checkBox3.TintColor = System.Drawing.Color.Red;
            // 
            // checkBox4
            // 
            this.checkBox4.Checked = true;
            this.checkBox4.Location = new System.Drawing.Point(217, 119);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(22, 22);
            this.checkBox4.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.checkBox4.TintColor = System.Drawing.Color.Red;
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
            this.checkBox5,
            this.checkBox6,
            this.checkBox7,
            this.checkBox8});
            this.panel2.Location = new System.Drawing.Point(5, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 181);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(0, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 54);
            this.label5.Text = "Enabled设置是否已启用CheckBox";
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
            this.label6.Text = "复选框特色属性";
            // 
            // checkBox5
            // 
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(45, 119);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(22, 22);
            // 
            // checkBox6
            // 
            this.checkBox6.Checked = true;
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(99, 119);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(22, 22);
            // 
            // checkBox7
            // 
            this.checkBox7.Enabled = false;
            this.checkBox7.Location = new System.Drawing.Point(157, 119);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(22, 22);
            this.checkBox7.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.checkBox7.TintColor = System.Drawing.Color.Red;
            // 
            // checkBox8
            // 
            this.checkBox8.Checked = true;
            this.checkBox8.Enabled = false;
            this.checkBox8.Location = new System.Drawing.Point(217, 119);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(22, 22);
            this.checkBox8.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.checkBox8.TintColor = System.Drawing.Color.Red;
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
            this.checkBox9});
            this.panel3.Location = new System.Drawing.Point(5, 401);
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
            this.label13.Text = "CheckedChanged在选择改变时触发";
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
            this.label14.Text = "复选框事件";
            // 
            // checkBox9
            // 
            this.checkBox9.Location = new System.Drawing.Point(133, 107);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(22, 22);
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // demoCheckBox
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoCheckBox";

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
        private Core.Controls.CheckBox checkBox1;
        private Core.Controls.CheckBox checkBox2;
        private Core.Controls.CheckBox checkBox3;
        private Core.Controls.CheckBox checkBox4;
        private Core.Controls.CheckBox checkBox5;
        private Core.Controls.CheckBox checkBox6;
        private Core.Controls.CheckBox checkBox7;
        private Core.Controls.CheckBox checkBox8;
        private Core.Controls.CheckBox checkBox9;
    }
}