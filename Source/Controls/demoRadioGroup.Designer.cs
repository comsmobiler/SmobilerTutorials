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
            Smobiler.Core.Controls.RadioButton radioButton1 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton2 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton3 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton4 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton5 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton6 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton7 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton8 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton9 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton10 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton11 = new Smobiler.Core.Controls.RadioButton();
            Smobiler.Core.Controls.RadioButton radioButton12 = new Smobiler.Core.Controls.RadioButton();
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
            this.labContent.FontSize = 15F;
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
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 35);
            this.label1.Text = "Buttons属性可设置选择按钮集合:\r\n";
            // 
            // label2
            // 
            this.label2.FontSize = 14F;
            this.label2.Location = new System.Drawing.Point(0, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 43);
            this.label2.Text = "FontSize、ForeColor、GridLines、GridLinesColor属性可设置字体大小、字体颜色、是否显示网格线、网格线颜色：";
            // 
            // label3
            // 
            this.label3.FontSize = 14F;
            this.label3.Location = new System.Drawing.Point(0, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 40);
            this.label3.Text = "ButtonStyle、MultiSelect、ButtonHeight属性可设置按钮显示位置、是否支持多选、按钮高度：\r\n";
            // 
            // label4
            // 
            this.label4.FontSize = 14F;
            this.label4.Location = new System.Drawing.Point(0, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 78);
            this.label4.Text = "SetRadioButtonCheckedByID方法可根据选项按钮ID设置选择状态（使用方法设置第一行）\r\nButtonPress在集合项点击时发生：\r\n";
            // 
            // radioGroup1
            // 
            radioButton1.ID = "1";
            radioButton1.Text = "第一行";
            radioButton1.Value = "1";
            radioButton2.ID = "2";
            radioButton2.Text = "第二行";
            radioButton2.Value = "2";
            radioButton3.ID = "3";
            radioButton3.Text = "第三行";
            radioButton3.Value = "3";
            this.radioGroup1.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton1,
            radioButton2,
            radioButton3});
            this.radioGroup1.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioGroup1.Location = new System.Drawing.Point(0, 121);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(290, 105);
            // 
            // radioGroup2
            // 
            this.radioGroup2.Border = new Smobiler.Core.Controls.Border(1F);
            this.radioGroup2.BorderColor = System.Drawing.Color.Silver;
            this.radioGroup2.ButtonHeight = 30;
            radioButton4.ID = "1";
            radioButton4.Text = "第一行";
            radioButton4.Value = "1";
            radioButton5.ID = "2";
            radioButton5.Text = "第二行";
            radioButton5.Value = "2";
            radioButton6.ID = "3";
            radioButton6.Text = "第三行";
            radioButton6.Value = "3";
            this.radioGroup2.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton4,
            radioButton5,
            radioButton6});
            this.radioGroup2.FontSize = 16F;
            this.radioGroup2.ForeColor = System.Drawing.Color.Red;
            this.radioGroup2.GridLines = true;
            this.radioGroup2.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioGroup2.Location = new System.Drawing.Point(0, 277);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Size = new System.Drawing.Size(290, 90);
            // 
            // radioGroup3
            // 
            this.radioGroup3.ButtonHeight = 25;
            radioButton7.ID = "1";
            radioButton7.Text = "第一行";
            radioButton7.Value = "1";
            radioButton8.ID = "2";
            radioButton8.Text = "第二行";
            radioButton8.Value = "2";
            radioButton9.ID = "3";
            radioButton9.Text = "第三行";
            radioButton9.Value = "3";
            this.radioGroup3.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton7,
            radioButton8,
            radioButton9});
            this.radioGroup3.ButtonStyle = Smobiler.Core.Controls.RadioGroupStyle.Left;
            this.radioGroup3.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioGroup3.Location = new System.Drawing.Point(0, 431);
            this.radioGroup3.MultiSelect = true;
            this.radioGroup3.Name = "radioGroup3";
            this.radioGroup3.Size = new System.Drawing.Size(290, 75);
            // 
            // radioGroup4
            // 
            radioButton10.ID = "1";
            radioButton10.Text = "第一行";
            radioButton10.Value = "1";
            radioButton11.ID = "2";
            radioButton11.Text = "第二行";
            radioButton11.Value = "2";
            radioButton12.ID = "3";
            radioButton12.Text = "第三行";
            radioButton12.Value = "3";
            this.radioGroup4.Buttons.AddRange(new Smobiler.Core.Controls.RadioButton[] {
            radioButton10,
            radioButton11,
            radioButton12});
            this.radioGroup4.GridLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioGroup4.Location = new System.Drawing.Point(0, 591);
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