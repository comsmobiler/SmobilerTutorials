using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoSignatureView : Smobiler.Core.Controls.MobileForm
    {
        public demoSignatureView()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private Random rd = new Random();
        private void btnColor_Press(object sender, EventArgs e)
        {
            signatureView1.StrokeColor = GetRandomColor();
        }
        private System.Drawing.Color GetRandomColor()
        {
            return System.Drawing.Color.FromArgb(rd.Next(0, 256), rd.Next(0, 256), rd.Next(0, 256));
        }
        private void btnWidth_Press(object sender, EventArgs e)
        {
            signatureView1.StrokeWidth = rd.Next(1, 15);
            btnWidth.Text = "Width" + signatureView1.StrokeWidth.ToString();
        }

        private void btnSave_Press(object sender, EventArgs e)
        {
            signatureView1.Save();
        }

        private void btnClear_Press(object sender, EventArgs e)
        {
            signatureView1.Clear();
        }

        private void signatureView1_OnSignatureImageSave(object sender, BinaryResultArgs e)
        {
            e.SaveFile();
            image1.ResourcePath = MobileResourceManager.DefaultUploadPath;
            image1.ResourceID = e.ResourceID;
        }
    }
}