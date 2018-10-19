using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Controls
{
    partial class demoRadioGroup : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.RadioButton radioButton13 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton14 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton15 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton16 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton17 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton18 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton19 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton20 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton21 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton22 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton23 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton24 = new Smobiler.Core.Controls.RadioButton();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel10 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.radioGroup1 = new Smobiler.Core.Controls.RadioGroup();
            this.radioGroup2 = new Smobiler.Core.Controls.RadioGroup();
            this.radioGroup3 = new Smobiler.Core.Controls.RadioGroup();
            this.radioGroup4 = new Smobiler.Core.Controls.RadioGroup();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "RadioGroup";
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
            this.radioGroup1,
            this.radioGroup2,
            this.radioGroup3,
            this.radioGroup4});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 737);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "选项按钮组控件,不同样式的选项按钮组控件";
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
            this.labTitle.Text = "RadioGroup控件";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 35);
            this.label1.Text = "Buttons属性可设置选择按钮集合:\r\n";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 35);
            this.label2.Text = "FontSize、ForeColor、GridLines、GridLinesColor属性可设置字体大小、字体颜色、是否显示网格线、网格线颜色：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 35);
            this.label3.Text = "ButtonStyle、MultiSelect、ButtonHeight属性可设置按钮显示位置、是否支持多选、按钮高度：\r\n";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 49);
            this.label4.Text = "SetRadioButtonCheckedByID方法可根据选项按钮ID设置选择状态（使用方法设置第一行）\r\nButtonPress在集合项点击时发生：\r\n";
            // 
            // radioGroup1
            // 
            radioButton13.ID = "1";
            radioButton13.Text = "第一行";
            radioButton13.Value = "1";
            radioButton14.ID = "2";
            radioButton14.Text = "第二行";
            radioButton14.Value = "2";
            radioButton15.ID = "3";
            radioButton15.Text = "第三行";
            radioButton15.Value = "3";
            this.radioGroup1.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton13,
            radioButton14,
            radioButton15});
            this.radioGroup1.Location = new System.Drawing.Point(0, 121);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(290, 105);
            // 
            // radioGroup2
            // 
            this.radioGroup2.Border = new Smobiler.Core.Controls.Border(1F);
            this.radioGroup2.BorderColor = System.Drawing.Color.Silver;
            radioButton16.ID = "1";
            radioButton16.Text = "第一行";
            radioButton16.Value = "1";
            radioButton17.ID = "2";
            radioButton17.Text = "第二行";
            radioButton17.Value = "2";
            radioButton18.ID = "3";
            radioButton18.Text = "第三行";
            radioButton18.Value = "3";
            this.radioGroup2.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton16,
            radioButton17,
            radioButton18});
            this.radioGroup2.FontSize = 16F;
            this.radioGroup2.ForeColor = System.Drawing.Color.Red;
            this.radioGroup2.GridLines = true;
            this.radioGroup2.Location = new System.Drawing.Point(0, 277);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Size = new System.Drawing.Size(290, 105);
            // 
            // radioGroup3
            // 
            this.radioGroup3.ButtonHeight = 25;
            radioButton19.ID = "1";
            radioButton19.Text = "第一行";
            radioButton19.Value = "1";
            radioButton20.ID = "2";
            radioButton20.Text = "第二行";
            radioButton20.Value = "2";
            radioButton21.ID = "3";
            radioButton21.Text = "第三行";
            radioButton21.Value = "3";
            this.radioGroup3.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton19,
            radioButton20,
            radioButton21});
            this.radioGroup3.ButtonStyle = Smobiler.Core.Controls.RadioGroupStyle.Left;
            this.radioGroup3.Location = new System.Drawing.Point(0, 431);
            this.radioGroup3.MultiSelect = true;
            this.radioGroup3.Name = "radioGroup3";
            this.radioGroup3.Size = new System.Drawing.Size(290, 75);
            // 
            // radioGroup4
            // 
            radioButton22.ID = "1";
            radioButton22.Text = "第一行";
            radioButton22.Value = "1";
            radioButton23.ID = "2";
            radioButton23.Text = "第二行";
            radioButton23.Value = "2";
            radioButton24.ID = "3";
            radioButton24.Text = "第三行";
            radioButton24.Value = "3";
            this.radioGroup4.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton22,
            radioButton23,
            radioButton24});
            this.radioGroup4.Location = new System.Drawing.Point(0, 569);
            this.radioGroup4.Name = "radioGroup4";
            this.radioGroup4.Size = new System.Drawing.Size(290, 105);
            this.radioGroup4.ButtonPress += new Smobiler.Core.Controls.RadioButtonPressEventHandler(this.radioGroup4_ButtonPress);
            // 
            // demoRadioGroup
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Load += new System.EventHandler(this.demoRadioGroup_Load);
            this.Name = "demoRadioGroup";

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
        private Core.Controls.RadioGroup radioGroup1;
        private Core.Controls.RadioGroup radioGroup2;
        private Core.Controls.RadioGroup radioGroup3;
        private Core.Controls.RadioGroup radioGroup4;
    }
}