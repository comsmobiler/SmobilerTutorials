using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Tutorials.Samples.Layout.UserControl;

namespace Smobiler.Tutorials.Samples.Layout
{
    partial class demoTabToolbar : Smobiler.Core.Controls.MobileForm
    {
        public demoTabToolbar() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolBar_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            if (toolBar.SelectedIndex!=tabPageView1.PageIndex)
            {
                switch (e.Name)
                {
                    case "仓库":
                        tabPageView1.PageIndex = 0;
                        break;
                    case "订单":
                        tabPageView1.PageIndex = 1;
                        break;
                    case "主数据":
                        tabPageView1.PageIndex = 2;
                        break;
                    case "统计":
                        tabPageView1.PageIndex = 3;
                        break;
                    case "设置":
                        tabPageView1.PageIndex = 4;
                        break;

                }
            }
        }

        private void demoTabToolbar_Load(object sender, EventArgs e)
        {

            tabPageView1.Controls.Add(new frmMenu() { Dock = System.Windows.Forms.DockStyle.Fill });
            tabPageView1.Controls.Add(new frmOrder() { Dock = System.Windows.Forms.DockStyle.Fill });
            tabPageView1.Controls.Add(new frmMasterData() { Dock = System.Windows.Forms.DockStyle.Fill });
            tabPageView1.Controls.Add(new frmAnalyze() { Dock = System.Windows.Forms.DockStyle.Fill });
            tabPageView1.Controls.Add(new frmUser() { Dock = System.Windows.Forms.DockStyle.Fill });
            toolBar.SelectedIndex = 0;
        }

        private void tabPageView1_PageIndexChanged(object sender, EventArgs e)
        {
                toolBar.SelectedIndex = tabPageView1.PageIndex;
        }

        private void demoTabToolbar_ActionButtonPress(object sender, ActionButtonPressEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    this.Form.Close();
                    break;
              
            }
        }
    }
}