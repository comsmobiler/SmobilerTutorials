using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Samples
{
    partial class demoListViewRemove : Smobiler.Core.Controls.MobileForm
    {
        public demoListViewRemove() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoListViewRemove_Load(object sender, EventArgs e)
        {
            this.listView1.TemplateControl = new demoListViewRemoveTemplate();
            DataTable dt = new DataTable();
            dt.Columns.Add("label", typeof(string));
            for (int i = 0; i < 10; i++)
            {
                dt.Rows.Add(i.ToString());
            }

            this.listView1.DataSource = dt;
            this.listView1.DataBind();
        }

        private int RemoveIndex;
        internal void RemoveNum(int index)
        {
            RemoveIndex = index;
        }
        private void btnRemoveIndex_Press(object sender, EventArgs e)
        {   
            //移除指定项
            this.listView1.Rows.RemoveAt(RemoveIndex);
        }
    }
}