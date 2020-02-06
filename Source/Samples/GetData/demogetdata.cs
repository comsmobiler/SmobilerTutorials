using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using System.ComponentModel;

namespace Smobiler.Tutorials.Samples
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demogetdata : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// 在选择完成时发生。
        /// </summary>
        [Description("在选择完成时发生。")]
        public event SelectedEventHandler Selected;

        private void SmobilerForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(System.Int32));
            table.Rows.Add(1);
            table.Rows.Add(2);
            listView1.Rows.Clear();     //清除数据
            if (table.Rows.Count > 0)    //绑定数据源
            {
                listView1.DataSource = table;
                listView1.DataBind();
            }
        }

        internal void OnSelected(string text)
        {
            if (this.Selected != null)
                this.Selected(this, new SelectedEventArgs(text));
            this.Close();
        }

    }
}