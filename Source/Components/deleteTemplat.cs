using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class deleteTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public deleteTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("确认要删除选中行项？", MessageBoxButtons.YesNo, (Object s1, MessageBoxHandlerArgs args) =>
                {
                    if (args.Result == Smobiler.Core.Controls.ShowResult.Yes)
                    {
                        ListViewRow row = this.Parent.Parent.Tag as ListViewRow;
                        ((demoSwipeView)this.Form).deleteRows(row); 
                        Toast("删除消费模板成功");
                    }
                });
            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
           
        }
    }
}