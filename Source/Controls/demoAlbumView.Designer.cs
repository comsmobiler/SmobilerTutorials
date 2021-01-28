using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Controls
{
    partial class demoAlbumView : Smobiler.Core.Controls.MobileForm
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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.albumView1 = new Smobiler.Core.Controls.AlbumView();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "AlbumView";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.albumView1});
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
            this.button1});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 123);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "可添加图片，点击图片可查看大图";
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
            this.labTitle.Text = "相册控件";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(39, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 30);
            this.button1.Text = "控件介绍";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // albumView1
            // 
            this.albumView1.AllowDelete = true;
            this.albumView1.Location = new System.Drawing.Point(0, 140);
            this.albumView1.Name = "albumView1";
            this.albumView1.Size = new System.Drawing.Size(300, 300);
            this.albumView1.DeletePress += new Smobiler.Core.Controls.AlbumViewItemDeleteEventHandler(this.albumView1_DeletePress);
            // 
            // popList1
            // 
            this.popList1.Name = "popList1";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // demoAlbumView
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Load += new System.EventHandler(this.demoAlbumView_Load);
            this.Name = "demoAlbumView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Button button1;
        private Core.Controls.AlbumView albumView1;
        private Core.Controls.PopList popList1;
    }
}