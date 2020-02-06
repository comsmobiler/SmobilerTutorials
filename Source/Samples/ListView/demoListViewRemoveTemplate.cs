using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demoListViewRemoveTemplate : Smobiler.Core.Controls.MobileUserControl
    {
       private Smobiler.Core.Controls.ListView lv;
        private  ListViewRow lvRow;
        private void btnRemove_Press(object sender, EventArgs e)
        {

            lv = this.Owner as Smobiler.Core.Controls.ListView;
            lvRow = this.Tag as ListViewRow;
            int rowIndex = lv.Rows.IndexOf(lvRow);
            demoListViewRemove dl = lv.Owner as demoListViewRemove;
            dl.RemoveNum(rowIndex);
            
            //也可直接移除本项
            //lv.Rows.Remove(lvRow);

        }
        private void btnChangeLabel_Press(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text+ DateTime.Now.ToString();
        }

        internal void ShowCheckBox(bool visible)
        {
            this.checkBox1.Visible = visible;
        }
    }
}