using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Samples.ListView
{
    partial class demoListViewRowBind : Smobiler.Core.Controls.MobileForm
    {
        public demoListViewRowBind() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoListViewRowBind_Load(object sender, EventArgs e)
        {
            this.listView1.TemplateControl = new demoListViewTemplateUpdateControl();
            DataTable dt = new DataTable();
            dt.Columns.Add("label1");
            dt.Columns.Add("label2");
            for (int i = 0; i < 10; i++)
                dt.Rows.Add("商品" + i.ToString(), i * 2 + 1);
            listView1.DataSource = dt;
            listView1.DataBind();
        }

        private void listView1_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            //在行绑定后发生
            if(((Label)e.Row.Control.Controls.Find("label2")).Text=="1")
            {
                ((Button)e.Row.Control.Controls.Find("button1")).Text = "跳转";
                e.Row.Control.BackColor = System.Drawing.Color.Red;
            }
        }

        private void listView1_RowBinding(object sender, ListViewTemplateBindEventArgs e)
        {
            //在行绑定            
             e.Row.Control.BackColor = System.Drawing.Color.Silver;
        }
    }
}