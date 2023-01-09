﻿using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoAdvert : Smobiler.Core.Controls.MobileForm
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
            this.advert1 = new Smobiler.Plugins.Advert();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Advert";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // advert1
            // 
            this.advert1.Name = "advert1";
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
            this.button1,
            this.button2});
            this.panel2.Location = new System.Drawing.Point(4, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 223);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 87);
            this.labContent.Text = "使用需要登陆注册腾讯优量汇平台，并获取APPID和激励位ID";
            this.labContent.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
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
            this.labTitle.Text = "腾讯优量汇广告插件（仅支持APP端）";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Location = new System.Drawing.Point(40, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 35);
            this.button1.Text = "Android点击";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.Location = new System.Drawing.Point(40, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 35);
            this.button2.Text = "iOS点击";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // demoAdvert
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.advert1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel2});
            this.Name = "demoAdvert";

        }
        #endregion

        private Core.Controls.Title title1;
        private Smobiler.Plugins.Advert advert1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
    }
}