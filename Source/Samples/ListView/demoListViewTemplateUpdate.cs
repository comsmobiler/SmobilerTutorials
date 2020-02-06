using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples.ListView
{
    partial class demoListViewTemplateUpdate : Smobiler.Core.Controls.MobileForm
    {
        public demoListViewTemplateUpdate() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoListViewTemplateUpdate_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("label1");
            dt.Columns.Add("label2");
            for (int i = 0; i < 10; i++)
                dt.Rows.Add("商品" + i.ToString(), i * 2 + 1);
            listView1.DataSource = dt;
            listView1.DataBind();

        }
    }
}