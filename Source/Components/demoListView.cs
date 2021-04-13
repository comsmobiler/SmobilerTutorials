using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoListView : Smobiler.Core.Controls.MobileForm
    {
        public demoListView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private void demoListView_Load(object sender, EventArgs e)
        {
            PopListGroup pg1 = new PopListGroup();
            pg1.AddListItem("DataBind");
            pg1.AddListItem("删除行");
            pg1.AddListItem("清空");
            pg1.AddListItem("新增行");
            pg1.AddListItem("编辑");
            popList1.Groups.Add(pg1);
            DataTable dt = new DataTable();
            dt.Columns.Add("img");
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("sexual");
            string[] sex = new string[] { "男", "女" };
            string[] pic = new string[] { "boy.png", "girl.png" };
            for (int i = 0; i < 8; i++)
            {
                dt.Rows.Add(pic[i%2], i, "user" + i.ToString(), sex[i % 2]);
            }
            //listView2绑定数据
            listView2.TemplateControl = new listViewTemplate();
            listView2.DataSource = dt;
            listView2.DataBind();
            //listView3绑定数据
            listView3.TemplateControl = new listViewTemplate();
            listView3.DataSource = dt;
            listView3.DataBind();

            //listView4 绑定数据
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("id");
            dt1.Columns.Add("cb");
            dt1.Columns.Add("lb1");
            dt1.Columns.Add("lb2");
            dt1.Columns.Add("lb3");

            for (int i = 0; i < 5; i++)
            {
                dt1.Rows.Add(i, false, i + 5, i * 10 + 5, i * 100 + 5);
            }
            listView4.TemplateControl = new tableTemplate();
            listView4.DataSource = dt1;
            listView4.DataBind();

        }

        private void button1_Press(object sender, EventArgs e)
        {
            popList1.ShowDialog();
        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selections[0].Text)
            {
                case "DataBind":
                    DataBind();
                    button1.Text = "数据绑定";
                    break;
                case "删除行":
                    if (listView1.Rows.Count > 0)
                    {
                        int i = listView1.Rows.Count;
                        listView1.Rows.RemoveAt(i - 1);
                        labContent.Text = "listView1.Rows.Remove ,listView1.Rows.RemoveAt删除行。";
                    }
                    button1.Text = "删除行";
                    break;
                case "清空":
                    listView1.Rows.Clear();
                    button1.Text = "清空";
                    break;
                case "新增行":
                    gridTable = new DataTable();
                    gridTable.Columns.Add("img");
                    gridTable.Columns.Add("id");
                    gridTable.Columns.Add("name");
                    gridTable.Columns.Add("sexual");
                    string[] sex = new string[] { "男", "女" };
                    string[] pic = new string[] { "boy.png", "girl.png" };
                    for (int i = 9; i < 12; i++)
                    {
                        gridTable.Rows.Add(pic[i%2], i, "user" + i.ToString(), sex[i % 2]);
                    }
                    listView1.NewRow(gridTable, "");
                    labContent.Text = "gridView1.NewCell 新增行。";
                    button1.Text = "新增行";
                    break;
                case "编辑":
                    button1.Text = "点击行项进行编辑";
                    break;
            }
        }
        DataTable gridTable;
        private void DataBind()
        {
            gridTable = new DataTable();
            gridTable.Columns.Add("img");
            gridTable.Columns.Add("id");
            gridTable.Columns.Add("name");
            gridTable.Columns.Add("sexual");
            string[] sex = new string[] { "男", "女" };
            string[] pic= new string[] { "boy.png", "girl.png" };
            for (int i = 0; i < 8; i++)
            {
                gridTable.Rows.Add(pic[i%2], i, "user" + i.ToString(), sex[i % 2]);
            }

            if (gridTable.Rows.Count > 0)
            {
                listView1.DataSource = gridTable;
                listView1.DataBind();
            }

        }
        int n = 5;

        private void listView3_ReachEnd(object sender, EventArgs e)
        {
            if (n < 30)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("img");
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Columns.Add("sexual");
                string[] sex = new string[] { "男", "女" };
                string[] pic = new string[] { "boy.png", "girl.png" };
                for (int i = n; i < n + 5; i++)
                {
                    dt.Rows.Add(pic[i%2], i, "user" + i.ToString(), sex[i % 2]);
                }
                listView3.NewRow(dt, "");
                n += 5;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (ListViewRow lr in listView4.Rows)
                {
                    ((CheckBox)(lr.Control.Controls.Find("checkBox1", true))).Checked = true;
                }
                DataTable dt = listView4.DataSource as DataTable;
                int i = 0, j = 0, k = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    i += Convert.ToInt32(dr[2]);
                    j += Convert.ToInt32(dr[3]);
                    k += Convert.ToInt32(dr[4]);
                }
                allLab1.Text = i.ToString();
                allLab2.Text = j.ToString();
                allLab3.Text = k.ToString();

            }
            else
            {
                foreach (ListViewRow lr in listView4.Rows)
                {
                    ((CheckBox)(lr.Control.Controls.Find("checkBox1", true))).Checked = false;
                }
                allLab1.Text = allLab2.Text = allLab3.Text = "0";
            }
        }
        public void countAll(CheckBox ck, string lb1, string lb2, string lb3)
        {
            if (ck.Checked)
            {
                allLab1.Text = (Convert.ToInt32(allLab1.Text) + Convert.ToInt32(lb1)).ToString();
                allLab2.Text = (Convert.ToInt32(allLab2.Text) + Convert.ToInt32(lb2)).ToString();
                allLab3.Text = (Convert.ToInt32(allLab3.Text) + Convert.ToInt32(lb3)).ToString();
            }
            else
            {
                allLab1.Text = (Convert.ToInt32(allLab1.Text) - Convert.ToInt32(lb1)).ToString();
                allLab2.Text = (Convert.ToInt32(allLab2.Text) - Convert.ToInt32(lb2)).ToString();
                allLab3.Text = (Convert.ToInt32(allLab3.Text) - Convert.ToInt32(lb3)).ToString();
            }
        }
    }
}