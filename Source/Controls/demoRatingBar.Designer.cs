using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Controls
{
    partial class demoRatingBar : Smobiler.Core.Controls.MobileForm
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
            this.ratingBar1 = new Smobiler.Core.Controls.RatingBar();
            this.ratingBar2 = new Smobiler.Core.Controls.RatingBar();
            this.ratingBar3 = new Smobiler.Core.Controls.RatingBar();
            this.ratingBar4 = new Smobiler.Core.Controls.RatingBar();
            this.ratingBar5 = new Smobiler.Core.Controls.RatingBar();
            this.ratingBar6 = new Smobiler.Core.Controls.RatingBar();
            this.ratingBar7 = new Smobiler.Core.Controls.RatingBar();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "RatingBar";
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
            this.ratingBar1,
            this.ratingBar2,
            this.ratingBar3,
            this.ratingBar4,
            this.ratingBar5,
            this.ratingBar6,
            this.ratingBar7});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 533);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "评价控件，不同样式的评价控件";
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
            this.labTitle.Text = "RatingBar控件";
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 35);
            this.label1.Text = "NumRating属性可设置评价数量:\r\n";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 47);
            this.label2.Text = "ResourceID与SelectedResourceID、ResourceColor与SelectedResourceColor属性可设置未选中与选择状态的图像" +
    "资源与颜色:\r\n";
            // 
            // label3
            // 
            this.label3.FontSize = 15F;
            this.label3.Location = new System.Drawing.Point(0, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 35);
            this.label3.Text = "ImageType属性可设置图像类型:\r\n";
            // 
            // label4
            // 
            this.label4.FontSize = 15F;
            this.label4.Location = new System.Drawing.Point(0, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 35);
            this.label4.Text = "Value属性可设置当前评分值:";
            // 
            // ratingBar1
            // 
            this.ratingBar1.Location = new System.Drawing.Point(0, 121);
            this.ratingBar1.Name = "ratingBar1";
            this.ratingBar1.Size = new System.Drawing.Size(202, 35);
            // 
            // ratingBar2
            // 
            this.ratingBar2.Location = new System.Drawing.Point(0, 156);
            this.ratingBar2.Name = "ratingBar2";
            this.ratingBar2.NumRatings = 3;
            this.ratingBar2.Size = new System.Drawing.Size(202, 35);
            // 
            // ratingBar3
            // 
            this.ratingBar3.Location = new System.Drawing.Point(0, 245);
            this.ratingBar3.Name = "ratingBar3";
            this.ratingBar3.ResourceID = "thumbs-o-up";
            this.ratingBar3.SelectedResourceID = "thumbs-up";
            this.ratingBar3.Size = new System.Drawing.Size(202, 35);
            // 
            // ratingBar4
            // 
            this.ratingBar4.Location = new System.Drawing.Point(0, 280);
            this.ratingBar4.Name = "ratingBar4";
            this.ratingBar4.ResourceColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ratingBar4.ResourceID = "thumbs-o-up";
            this.ratingBar4.SelectedResourceColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(99)))));
            this.ratingBar4.SelectedResourceID = "thumbs-up";
            this.ratingBar4.Size = new System.Drawing.Size(202, 35);
            // 
            // ratingBar5
            // 
            this.ratingBar5.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.Image;
            this.ratingBar5.Location = new System.Drawing.Point(0, 363);
            this.ratingBar5.Name = "ratingBar5";
            this.ratingBar5.ResourceID = "logon";
            this.ratingBar5.SelectedResourceID = "logon";
            this.ratingBar5.Size = new System.Drawing.Size(202, 35);
            // 
            // ratingBar6
            // 
            this.ratingBar6.Location = new System.Drawing.Point(0, 445);
            this.ratingBar6.Name = "ratingBar6";
            this.ratingBar6.ResourceColor = System.Drawing.Color.Silver;
            this.ratingBar6.ResourceID = "thumbs-o-up";
            this.ratingBar6.SelectedResourceColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(78)))));
            this.ratingBar6.SelectedResourceID = "thumbs-up";
            this.ratingBar6.Size = new System.Drawing.Size(202, 35);
            this.ratingBar6.Value = 2;
            // 
            // ratingBar7
            // 
            this.ratingBar7.Location = new System.Drawing.Point(0, 480);
            this.ratingBar7.Name = "ratingBar7";
            this.ratingBar7.ResourceID = "thumbs-o-up";
            this.ratingBar7.SelectedResourceID = "thumbs-up";
            this.ratingBar7.Size = new System.Drawing.Size(202, 35);
            this.ratingBar7.Value = 5;
            // 
            // demoRatingBar
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoRatingBar";

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
        private Core.Controls.RatingBar ratingBar1;
        private Core.Controls.RatingBar ratingBar2;
        private Core.Controls.RatingBar ratingBar3;
        private Core.Controls.RatingBar ratingBar4;
        private Core.Controls.RatingBar ratingBar5;
        private Core.Controls.RatingBar ratingBar6;
        private Core.Controls.RatingBar ratingBar7;
    }
}