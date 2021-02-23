using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class gridAddTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public gridAddTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.ShowResult = ShowResult.Cancel;
            this.Close();
        }
        public DataTable dataTable;
        private void button2_Press(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("img");
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("sexual");
            dt.Rows.Add("logon", idtxt.Text, nametxt.Text, sextxt.Text);
            dataTable = dt;
            this.ShowResult = ShowResult.Yes;
            this.Close();
        }
    }
}