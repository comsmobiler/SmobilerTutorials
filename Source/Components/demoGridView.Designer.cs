using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoGridView : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.gridView2 = new Smobiler.Core.Controls.GridView();
            this.gridView3 = new Smobiler.Core.Controls.GridView();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.gridView4 = new Smobiler.Core.Controls.GridView();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.gridView1,
            this.panel3,
            this.label3,
            this.label4,
            this.gridView2,
            this.gridView3,
            this.panel4,
            this.gridView4});
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
            this.panel2.Size = new System.Drawing.Size(290, 168);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 87);
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
            this.button1.Location = new System.Drawing.Point(42, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 30);
            this.button1.Text = "控件介绍";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // gridView1
            // 
            this.gridView1.BackColor = System.Drawing.Color.White;
            this.gridView1.Location = new System.Drawing.Point(5, 188);
            this.gridView1.Name = "gridView1";
            this.gridView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridView1.PageSizeTextSize = 11F;
            this.gridView1.Size = new System.Drawing.Size(290, 210);
            this.gridView1.TemplateControlName = "listViewTemplate";
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
            this.panel3.Location = new System.Drawing.Point(5, 408);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 113);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 86);
            this.label1.Text = "方法1：通过设置PageSize实现分页\r\n方法2:在GridView的ReachEnd通过NewCell方法实现分页 （RaiseReachEnd属性设置tru" +
    "e时，可在gridview滑动到底部时触发ReachEnd事件）";
            this.label1.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
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
            this.label3.Location = new System.Drawing.Point(5, 531);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(290, 26);
            this.label3.Text = "方法1";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(5, 751);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(290, 26);
            this.label4.Text = "方法2";
            // 
            // gridView2
            // 
            this.gridView2.BackColor = System.Drawing.Color.White;
            this.gridView2.Location = new System.Drawing.Point(5, 567);
            this.gridView2.Name = "gridView2";
            this.gridView2.PageSize = 5;
            this.gridView2.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridView2.PageSizeTextSize = 11F;
            this.gridView2.Size = new System.Drawing.Size(290, 174);
            // 
            // gridView3
            // 
            this.gridView3.BackColor = System.Drawing.Color.White;
            this.gridView3.Location = new System.Drawing.Point(5, 787);
            this.gridView3.Name = "gridView3";
            this.gridView3.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridView3.PageSizeTextSize = 11F;
            this.gridView3.RaiseReachEnd = true;
            this.gridView3.Size = new System.Drawing.Size(290, 174);
            this.gridView3.ReachEnd += new System.EventHandler(this.gridView3_ReachEnd);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.Silver;
            this.panel4.BorderRadius = 5;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.label6});
            this.panel4.Location = new System.Drawing.Point(5, 971);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 97);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FontSize = 15F;
            this.label5.Location = new System.Drawing.Point(0, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 71);
            this.label5.Text = "ColumnNum属性设置显示列数，只需设置ColumnNum=4，并且更换模板就可以很方便的实现\r\n";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label6.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.FontSize = 16F;
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label6.Size = new System.Drawing.Size(290, 26);
            this.label6.Text = "实现IconMenuView";
            // 
            // gridView4
            // 
            this.gridView4.BackColor = System.Drawing.Color.White;
            this.gridView4.ColumnNum = 4;
            this.gridView4.Location = new System.Drawing.Point(5, 1078);
            this.gridView4.Name = "gridView4";
            this.gridView4.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.gridView4.PageSizeTextSize = 11F;
            this.gridView4.Size = new System.Drawing.Size(290, 140);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "GridView";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // popList1
            // 
            this.popList1.Name = "popList1";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // demoGridView
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoGridView_Load);
            this.Name = "demoGridView";

        }
        #endregion
        private Core.Controls.Panel panel1;
        private Core.Controls.Title title1;
        private Core.Controls.PopList popList1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Button button1;
        private Core.Controls.GridView gridView1;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
        private Core.Controls.GridView gridView2;
        private Core.Controls.GridView gridView3;
        private Core.Controls.Panel panel4;
        private Core.Controls.Label label5;
        private Core.Controls.Label label6;
        private Core.Controls.GridView gridView4;
    }
}