using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoListView : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            this.listView3 = new Smobiler.Core.Controls.ListView();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.listView4 = new Smobiler.Core.Controls.ListView();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.allLab1 = new Smobiler.Core.Controls.Label();
            this.allLab2 = new Smobiler.Core.Controls.Label();
            this.allLab3 = new Smobiler.Core.Controls.Label();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ListView";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.panel3,
            this.label3,
            this.label4,
            this.panel4,
            this.listView1,
            this.listView2,
            this.listView3,
            this.panel5,
            this.listView4,
            this.panel6});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.button1});
            this.panel2.Location = new System.Drawing.Point(5, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 173);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 86);
            this.labContent.Text = "可进行数据绑定，添加数据集，删除数据集，清除数据集，设置数据集的操作\r\nGridView，ListView都没有点击事件，可以使用其模板页中控件的事件作为点击事件" +
    "\r\n";
            this.labContent.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labTitle.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.labTitle.FontSize = 16F;
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labTitle.Size = new System.Drawing.Size(290, 26);
            this.labTitle.Text = "表格显示控件";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Location = new System.Drawing.Point(39, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 30);
            this.button1.Text = "控件介绍";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2});
            this.panel3.Location = new System.Drawing.Point(5, 413);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 126);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 100);
            this.label1.Text = "方法1：通过设置PageSize实现分页\r\n方法2:在ListView的ReachEnd通过NewRowl方法实现分页 （RaiseReachEnd属性设置tru" +
    "e时，可在listview滑动到底部时触发ReachEnd事件）";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label2.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.FontSize = 16F;
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label2.Size = new System.Drawing.Size(290, 26);
            this.label2.Text = "实现分页";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(5, 549);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(290, 26);
            this.label3.Text = "方法1";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(5, 769);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(290, 26);
            this.label4.Text = "方法2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.Silver;
            this.panel4.BorderRadius = 5;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6});
            this.panel4.Location = new System.Drawing.Point(5, 989);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 26);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.FontSize = 16F;
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label6.Size = new System.Drawing.Size(290, 26);
            this.label6.Text = "实现表格\r\n";
            this.label6.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Location = new System.Drawing.Point(5, 193);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(290, 210);
            this.listView1.TemplateControlName = "listViewTemplate";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.White;
            this.listView2.Location = new System.Drawing.Point(5, 585);
            this.listView2.Name = "listView2";
            this.listView2.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView2.Size = new System.Drawing.Size(290, 174);
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.White;
            this.listView3.Location = new System.Drawing.Point(5, 805);
            this.listView3.Name = "listView3";
            this.listView3.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView3.RaiseReachEnd = true;
            this.listView3.Size = new System.Drawing.Size(290, 174);
            this.listView3.ReachEnd += new System.EventHandler(this.listView3_ReachEnd);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.checkBox1,
            this.label7,
            this.label8,
            this.label9});
            this.panel5.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel5.Flex = 1;
            this.panel5.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel5.Location = new System.Drawing.Point(5, 1025);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 30);
            // 
            // checkBox1
            // 
            this.checkBox1.DataMember = "id";
            this.checkBox1.DisplayMember = "cb";
            this.checkBox1.Margin = new Smobiler.Core.Controls.Margin(10F, 0F, 10F, 0F);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 30);
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.label7.Bold = true;
            this.label7.DisplayMember = "lb1";
            this.label7.Flex = 1;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 0);
            this.label7.Text = "label1";
            // 
            // label8
            // 
            this.label8.Bold = true;
            this.label8.DisplayMember = "lb2";
            this.label8.Flex = 1;
            this.label8.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 0);
            this.label8.Text = "label2";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.label9.Bold = true;
            this.label9.DisplayMember = "lb3";
            this.label9.Flex = 1;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 0);
            this.label9.Text = "label3";
            // 
            // listView4
            // 
            this.listView4.BackColor = System.Drawing.Color.White;
            this.listView4.Location = new System.Drawing.Point(5, 1055);
            this.listView4.Name = "listView4";
            this.listView4.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView4.Size = new System.Drawing.Size(290, 150);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label13,
            this.allLab1,
            this.allLab2,
            this.allLab3});
            this.panel6.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel6.Flex = 1;
            this.panel6.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel6.Location = new System.Drawing.Point(5, 1205);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 30);
            // 
            // label13
            // 
            this.label13.Bold = true;
            this.label13.Margin = new Smobiler.Core.Controls.Margin(10F, 0F, 10F, 0F);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 30);
            this.label13.Text = "All";
            // 
            // allLab1
            // 
            this.allLab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.allLab1.Bold = true;
            this.allLab1.DisplayMember = "lb1";
            this.allLab1.Flex = 1;
            this.allLab1.ForeColor = System.Drawing.Color.White;
            this.allLab1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.allLab1.Name = "allLab1";
            this.allLab1.Size = new System.Drawing.Size(100, 0);
            this.allLab1.Text = "0";
            // 
            // allLab2
            // 
            this.allLab2.Bold = true;
            this.allLab2.DisplayMember = "lb2";
            this.allLab2.Flex = 1;
            this.allLab2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.allLab2.Name = "allLab2";
            this.allLab2.Size = new System.Drawing.Size(100, 0);
            this.allLab2.Text = "0";
            // 
            // allLab3
            // 
            this.allLab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.allLab3.Bold = true;
            this.allLab3.DisplayMember = "lb3";
            this.allLab3.Flex = 1;
            this.allLab3.ForeColor = System.Drawing.Color.White;
            this.allLab3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.allLab3.Name = "allLab3";
            this.allLab3.Size = new System.Drawing.Size(100, 0);
            this.allLab3.Text = "0";
            // 
            // popList1
            // 
            this.popList1.Name = "popList1";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // demoListView
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoListView_Load);
            this.Name = "demoListView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Button button1;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
        private Core.Controls.Panel panel4;
        private Core.Controls.Label label6;
        private Core.Controls.ListView listView1;
        private Core.Controls.ListView listView2;
        private Core.Controls.ListView listView3;
        private Core.Controls.PopList popList1;
        private Core.Controls.Panel panel5;
        private Core.Controls.CheckBox checkBox1;
        private Core.Controls.Label label7;
        private Core.Controls.Label label8;
        private Core.Controls.Label label9;
        private Core.Controls.ListView listView4;
        private Core.Controls.Panel panel6;
        private Core.Controls.Label label13;
        private Core.Controls.Label allLab1;
        private Core.Controls.Label allLab2;
        private Core.Controls.Label allLab3;
    }
}