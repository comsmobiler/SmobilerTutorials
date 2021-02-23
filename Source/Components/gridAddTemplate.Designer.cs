using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class gridAddTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.nametxt = new Smobiler.Core.Controls.TextBox();
            this.sextxt = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.idtxt = new Smobiler.Core.Controls.TextBox();
            // 
            // title1
            // 
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "编辑";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.nametxt,
            this.sextxt,
            this.button1,
            this.button2,
            this.idtxt});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(27, 55);
            this.image1.Name = "image1";
            this.image1.ResourceID = "logon";
            this.image1.Size = new System.Drawing.Size(81, 79);
            // 
            // nametxt
            // 
            this.nametxt.Border = new Smobiler.Core.Controls.Border(1F);
            this.nametxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.nametxt.Location = new System.Drawing.Point(142, 83);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(120, 35);
            this.nametxt.WaterMarkText = "姓名";
            // 
            // sextxt
            // 
            this.sextxt.Border = new Smobiler.Core.Controls.Border(1F);
            this.sextxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.sextxt.Location = new System.Drawing.Point(142, 134);
            this.sextxt.Name = "sextxt";
            this.sextxt.Size = new System.Drawing.Size(120, 35);
            this.sextxt.WaterMarkText = "性别";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.button1.Location = new System.Drawing.Point(27, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "取消";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(174, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.Text = "保存";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // idtxt
            // 
            this.idtxt.Border = new Smobiler.Core.Controls.Border(1F);
            this.idtxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.idtxt.Location = new System.Drawing.Point(142, 34);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(120, 35);
            this.idtxt.WaterMarkText = "id";
            // 
            // gridAddTemplate
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(300, 300);
            this.Name = "gridAddTemplate";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Image image1;
        private Core.Controls.TextBox nametxt;
        private Core.Controls.TextBox sextxt;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
        private Core.Controls.TextBox idtxt;
    }
}