using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples.ShowDialog
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class userFooterDialog : Smobiler.Core.Controls.MobileUserControl
    {
        private void btnDone_Press(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}