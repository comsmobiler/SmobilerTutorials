using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoFingerPrint : Smobiler.Core.Controls.MobileForm
    {
        public demoFingerPrint()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void demoFingerPrint_Load(object sender, EventArgs e)
        {
            ListMenuViewGroup grp = new ListMenuViewGroup();
            grp.Items.Add(new ListMenuViewItem("logon", "是否支持指纹", "", "", "isSensorAvailable"));
            grp.Items.Add(new ListMenuViewItem("logon", "指纹验证", "", "", "authenticate"));
            this.listMenuView1.Groups.Add(grp);
            this.label1.Text = "这是指纹控件，主要有isSensorAvailable和authenticate方法";
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            switch(e.Item.Tag.ToString())
            {
                case "isSensorAvailable":
                    fingerPrint1.isSensorAvailable((obj, args) =>
                    {
                        if (args.isError == true)
                            this.Toast(args.error);
                        else
                            this.Toast("Support");
                    });
                    break;
                case "authenticate":
                    fingerPrint1.authenticate((obj, args) =>
                    {
                        if (args.isError == true)
                            this.Toast(args.error);
                        else
                            this.Toast("Support");
                    });
                    break;
            }
        }
    }
}


    