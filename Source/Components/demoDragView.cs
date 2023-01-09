using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Components
{
    partial class demoDragView : Smobiler.Core.Controls.MobileForm
    {
        public demoDragView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
           
        }

        private void demoDragView_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("num");
            dt.Columns.Add("sex");
            dt.Rows.Add("张三", "1", "男");
            dt.Rows.Add("李四", "2", "女");
            dt.Rows.Add("王五", "3", "男");
            dt.Rows.Add("赵六", "4", "男");
            dt.Rows.Add("孙七", "5", "女");
            dragView1.DataSource = dt;
            dragView1.DataBind();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {

        }
        private void dragView1_CellChanged(object sender, DragViewCellChangedEventArgs e)
        {
            //获取第一行数据的第一列的数据
            //Cell删除或者顺序发生变化后，dragView1.Cells也会改变
            Toast(((DataRowView)dragView1.Cells[0].Control.TemplateData)[0].ToString());
        }
        int i = 0;
        private void dragView1_CellBind(object sender, DragViewTemplateBindEventArgs e)
        {
            //双数行背景色设置蓝色
            if (i % 2 == 0)
                e.Cell.Control.BackColor = System.Drawing.Color.AliceBlue;
            i++;
        }
    }
}