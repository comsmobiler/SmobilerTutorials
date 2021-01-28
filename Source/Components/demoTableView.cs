using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoTableView : Smobiler.Core.Controls.MobileForm
    {
        public demoTableView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoTableView_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");    //编号
            table.Columns.Add("NAME");    //名称
            table.Columns.Add("Value");    //数量  
            table.Rows.Add("1", "图书", "20000");
            table.Rows.Add("2", "笔记本", "19500");
            table.Rows.Add("3", "硬盘", "19000");
            table.Rows.Add("4", "内存", "21000");
            if (table.Rows.Count > 0)    //绑定数据源
            {
                tableView1.DataSource = table;
                tableView1.DataBind();
            }
            //
            tableView2.DataSource = table;
            tableView2.DataBind();
        }

        private void tableView2_ButtonCellLongPress(object sender, TableViewButtonCellEventArgs e)
        {
            Toast("当前点击第"+e.Cell.RowIndex+"行，第"+e.Cell.Index+"列，值："+e.Cell.Text);
        }

        private void tableView2_ButtonCellPress(object sender, TableViewButtonCellEventArgs e)
        {
            Toast("当前点击第" + e.Cell.RowIndex + "行，第" + e.Cell.Index + "列，值：" + e.Cell.Text);

        }

        private void tableView2_CheckBoxCellCheckedChanged(object sender, TableViewCheckBoxCellEventArgs e)
        {
            Toast("当前checkboox值："+e.Cell.Checked.ToString());
        }

        private void tableView2_TextBoxCellTextChanged(object sender, TableViewTextBoxCellEventArgs e)
        {
            Toast(e.Cell.Text);
        }

        private void tableView2_TextBoxCellTouchEnter(object sender, TableViewTextBoxCellEventArgs e)
        {
            Toast("enter");
        }

        private void tableView2_TextBoxCellTouchLeave(object sender, TableViewTextBoxCellEventArgs e)
        {
            Toast("leave");
        }
    }
}