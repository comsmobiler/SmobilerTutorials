using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoSectionListView : Smobiler.Core.Controls.MobileForm
    {
        public demoSectionListView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            popList1.ShowDialog();
        }

        private void demoSectionListView_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("初始化数量20");
            g1.AddListItem("PickerBackColor");
            g1.AddListItem("PickerForeColor");
            g1.AddListItem("PickerFontSize");
            g1.AddListItem("获取第一行TemplateData");
            g1.AddListItem("获取第一行TemplateItem");
            g1.AddListItem("修改第一行DataSource");
            g1.AddListItem("Clear");
            g1.AddListItem("Add");
            g1.AddListItem("Remove");
            g1.AddListItem("初始化数量50");
            g1.AddListItem("分隔线");

            popList1.Groups.Add(g1);
            this.sectionListView1.SectionMember = "Section";
            this.sectionListView1.SectionPicker = true;
            this.sectionListView1.TemplateControl = new demoListViewTemplate();
            this.sectionListView1.SectionControl = new demoSectionListViewTemplate();



        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selections[0].Text)
            {
                case "初始化数量20":
                    DataTable dt = new DataTable();
           
                    dt.Columns.Add("lab");
                    dt.Columns.Add("Section");
                    for (int i = 0; i < 20; i++)
                    {
                        dt.Rows.Add( "user" + i.ToString(),i);
                    }
                    this.sectionListView1.DataSource = dt;
                    this.sectionListView1.DataBind();
                    break;
                case "PickerBackColor":
                    this.sectionListView1.PickerBackColor = System.Drawing.Color.White;
                    break;
                case "PickerForeColor":
                    this.sectionListView1.PickerForeColor = System.Drawing.Color.Yellow;
                    break;
                case "PickerFontSize":
                    this.sectionListView1.PickerFontSize = 16f;
                    break;
                case "获取第一行TemplateData":
                    System.Data.DataRowView rowData = this.sectionListView1.Rows[0].Control.TemplateData as System.Data.DataRowView;
                    if (rowData != null) Toast(rowData.ToString());
                    break;
                case "获取第一行TemplateItem":
                    SectionListViewRow rowItem = this.sectionListView1.Rows[0].Control.TemplateItem as SectionListViewRow;
                    if (rowItem != null) Toast(rowItem.ToString());
                    break;
                case "修改第一行DataSource":

                    break;
                case "Clear":
                    this.sectionListView1.Rows.Clear();
                    break;
                case "Add":
                    this.sectionListView1.NewRow(this.sectionListView1.Sections[0].SectionID);
                    break;
                case "Remove":
                    if (this.sectionListView1.Rows.Count > 0)
                        this.sectionListView1.Rows.RemoveAt(0);
                    break;
                case "初始化数量50":
                    this.sectionListView1.Rows.Clear();
                    DataTable dt1 = new DataTable();
                    dt1.Columns.Add("img");
                    dt1.Columns.Add("lab");
                    dt1.Columns.Add("Section");
                    for (int i = 0; i < 100; i++)
                    {
                        dt1.Rows.Add("logon", "test" + i.ToString(),i);
                    }
                    this.sectionListView1.DataSource = dt1;
                    this.sectionListView1.DataBind();
                    break;
                case "分隔线":
                    this.sectionListView1.ShowSplitLine = true;
                    this.sectionListView1.SplitLineColor = System.Drawing.Color.Red;
                    break;

            }
        }
    }
}