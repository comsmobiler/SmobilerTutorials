using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoGridView : Smobiler.Core.Controls.MobileForm
    {
        public demoGridView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private void demoGridView_Load(object sender, EventArgs e)
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
            //gridView2绑定数据
            gridView2.TemplateControl = new listViewTemplate();
            gridView2.DataSource = dt;
            gridView2.DataBind();
            //gridView3绑定数据
            gridView3.TemplateControl = new listViewTemplate();
            gridView3.DataSource = dt;
            gridView3.DataBind();

            //gridView4 绑定数据
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("img");
            dt1.Columns.Add("lab");
            dt1.Rows.Add("CF", "item1");
            dt1.Rows.Add("FZ", "item2");
            dt1.Rows.Add("GL", "item3");
            dt1.Rows.Add("KD", "item4");
            dt1.Rows.Add("WX", "item5");
            dt1.Rows.Add("XZ", "item6");
            dt1.Rows.Add("YJ", "item7");
            dt1.Rows.Add("ZS", "item8");
            gridView4.TemplateControl = new gridViewTemplate();
            gridView4.DataSource = dt1;
            gridView4.DataBind();
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
                    if (gridView1.Cells.Count > 0)
                    {
                        int i = gridView1.Cells.Count;
                        gridView1.Cells.RemoveAt(i - 1);
                        labContent.Text = "gridView1.Cells.Remove ,gridView1.Cells.RemoveAt删除行。";
                    }
                    button1.Text = "删除行";
                    break;
                case "清空":
                    gridView1.Cells.Clear();
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
                    for (int i = 6; i < 12; i++)
                    {
                        gridTable.Rows.Add(pic[i%2], i, "user" + i.ToString(), sex[i % 2]);
                    }
                    gridView1.NewCell(gridTable, "");
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
            string[] pic = new string[] { "boy.png", "girl.png" };
            for (int i = 0; i < 6; i++)
            {
                gridTable.Rows.Add(pic[i%2], i, "user" + i.ToString(), sex[i % 2]);
            }

            if (gridTable.Rows.Count > 0)
            {
                gridView1.DataSource = gridTable;
                gridView1.DataBind();
            }

        }
        int n = 5;
        private void gridView3_ReachEnd(object sender, EventArgs e)
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
                gridView3.NewCell(dt, "");
                n += 5;
            }
        }
    }
}