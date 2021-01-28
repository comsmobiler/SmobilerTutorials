using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoTextboxField : Smobiler.Core.Controls.MobileForm
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
            this.textBoxField1 = new Smobiler.Plugins.TextBoxField();
            // 
            // title1
            // 
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "TextBoxField";
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
            this.textBoxField1});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 257);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "Label属性设置头部文本，LabelBlurColor 在输入框无焦点时颜色，LabelFocusColor在输入有焦点时颜色；Text设置需要显示的文本";
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
            this.labTitle.Text = "带特效的文本框";
            // 
            // textBoxField1
            // 
            this.textBoxField1.Label = "Smobiler整体概述";
            this.textBoxField1.LabelFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.textBoxField1.Location = new System.Drawing.Point(18, 103);
            this.textBoxField1.Name = "textBoxField1";
            this.textBoxField1.Size = new System.Drawing.Size(250, 127);
            this.textBoxField1.Text = "显示的内容：Smobiler专注为开发者提供极致体验，是一套能够快速实施移动信息化战略的平台级产品。在快速实现系统建设目标的同时，提供了统一的移动技术标准和安全规" +
    "范";
            // 
            // demoTextboxField
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoTextboxField";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Smobiler.Plugins.TextBoxField textBoxField1;
    }
}