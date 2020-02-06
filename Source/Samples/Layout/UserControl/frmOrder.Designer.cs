using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.Layout.UserControl
{
    partial class frmOrder : Smobiler.Core.Controls.MobileUserControl
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
            this.scType = new Smobiler.Core.Controls.SegmentedControl();
            this.plAllData = new Smobiler.Core.Controls.Panel();
            this.plSNType = new Smobiler.Core.Controls.Panel();
            this.btnAss = new Smobiler.Core.Controls.Button();
            this.btnCon = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "订单";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.scType,
            this.plAllData});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 0);
            // 
            // scType
            // 
            this.scType.Items = new string[] {
        "采购订单",
        "销售订单"};
            this.scType.Name = "scType";
            this.scType.SegmentedBorderRadius = 0;
            this.scType.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.scType.SelectedColor = System.Drawing.Color.White;
            this.scType.Size = new System.Drawing.Size(0, 35);
            this.scType.UnSelectedBackColor = System.Drawing.Color.White;
            this.scType.UnSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.scType.SelectedIndexChanged += new System.EventHandler(this.scType_SelectedIndexChanged);
            // 
            // plAllData
            // 
            this.plAllData.BackColor = System.Drawing.Color.White;
            this.plAllData.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plSNType});
            this.plAllData.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.plAllData.Flex = 1;
            this.plAllData.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.plAllData.Name = "plAllData";
            this.plAllData.Size = new System.Drawing.Size(0, 100);
            // 
            // plSNType
            // 
            this.plSNType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plSNType.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnAss,
            this.btnCon});
            this.plSNType.Name = "plSNType";
            this.plSNType.Size = new System.Drawing.Size(40, 0);
            // 
            // btnAss
            // 
            this.btnAss.BackColor = System.Drawing.Color.White;
            this.btnAss.BorderRadius = 0;
            this.btnAss.ForeColor = System.Drawing.Color.Black;
            this.btnAss.Name = "btnAss";
            this.btnAss.Size = new System.Drawing.Size(40, 35);
            this.btnAss.Text = "资产";
            this.btnAss.Press += new System.EventHandler(this.btnAss_Press);
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCon.BorderRadius = 0;
            this.btnCon.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCon.Location = new System.Drawing.Point(0, 35);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(40, 35);
            this.btnCon.Text = "耗材";
            this.btnCon.Press += new System.EventHandler(this.btnCon_Press);
            // 
            // frmOrder
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Name = "frmOrder";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.SegmentedControl scType;
        private Smobiler.Core.Controls.Panel plAllData;
        private Smobiler.Core.Controls.Panel plSNType;
        private Smobiler.Core.Controls.Button btnAss;
        private Smobiler.Core.Controls.Button btnCon;
    }
}