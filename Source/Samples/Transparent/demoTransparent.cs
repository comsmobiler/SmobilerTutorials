using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples.Transparent
{
    partial class demoTransparent : Smobiler.Core.Controls.MobileForm
    {
        public demoTransparent()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void demoTransparent_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add(new System.Data.DataColumn("Image",typeof(string)));
            for(int i=0;i<5;i++)
            {
                dt.Rows.Add("logon.png");
            }
            this.pageView1.TemplateControl = new UserTransparentPageViewItem();
            this.pageView1.DataSource = dt;
            this.pageView1.DataBind();
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    class UserTransparentPageViewItem : MobileUserControl
    {
        public UserTransparentPageViewItem()
            : base()
        {
            this.Flex = 1;
            this.Size = System.Drawing.Size.Empty;
            this.Layout = LayoutPosition.Relative;
            Image image1 = new Image();
            image1.Flex = 1;
            image1.Size = System.Drawing.Size.Empty;
            image1.DisplayMember = "Image";
            image1.SizeMode = ImageSizeMode.Stretch;
            this.Controls.Add(image1);
        }
    }
}