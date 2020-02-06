using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class userFilterItemTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        private void panel1_Press(object sender, EventArgs e)
        {
            this.label1.ForeColor = System.Drawing.Color.Blue;
            ((userFilterItem)this.Owner.Owner.Owner).SetSelected((ListViewRow)this.Tag);
        }

        public void setUnSelected()
        {
            this.label1.ForeColor = System.Drawing.Color.Black;
        }
        
    }
}