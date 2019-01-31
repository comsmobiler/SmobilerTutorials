using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoMarqueeLabel : Smobiler.Core.Controls.MobileForm
    {
        public demoMarqueeLabel() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signatureView1_OnSignatureImageSave(object sender, BinaryResultArgs e)
        {

        }

        private void spinner1_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            switch (e.Item)
            {
                case "FontSize - 13":
                    this.marqueeLabel1.FontSize = 13f;
                    break;
                case "FontSize - 20":
                    this.marqueeLabel1.FontSize = 20f;
                    break;
                case "ForeColor - Red":
                    this.marqueeLabel1.ForeColor = System.Drawing.Color.Red;
                    break;
                case "ForeColor - Yellow":
                    this.marqueeLabel1.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case "Text - CurrentDate":
                    this.marqueeLabel1.Text = DateTime.Now.ToString();
                    break;
                case "HorizontalAlignment - Left":
                    this.marqueeLabel1.HorizontalAlignment = HorizontalAlignment.Left;
                    break;
                case "HorizontalAlignment - Center":
                    this.marqueeLabel1.HorizontalAlignment = HorizontalAlignment.Center;
                    break;
                case "HorizontalAlignment - Right":
                    this.marqueeLabel1.HorizontalAlignment = HorizontalAlignment.Right;
                    break;
                case "NumberOfLines-2":
                    this.marqueeLabel1.NumberOfLines = 2;
                    break;
                case "ScrollDurationt-30":
                    this.marqueeLabel1.ScrollDuration = 30;
                    break;
                case "Selectable-true":
                    this.marqueeLabel1.Selectable = true;
                    break;
                case "UnderLine-true":
                    this.marqueeLabel1.Underline = true;
                    break;
            }

            }
    }
}