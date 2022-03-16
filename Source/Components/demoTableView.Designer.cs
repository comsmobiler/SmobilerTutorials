using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoTableView : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn4 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn5 = new Smobiler.Core.Controls.TableViewLabelColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(demoTableView));
            Smobiler.Core.Controls.TableViewCheckBoxColumn tableViewCheckBoxColumn2 = new Smobiler.Core.Controls.TableViewCheckBoxColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn6 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewButtonColumn tableViewButtonColumn2 = new Smobiler.Core.Controls.TableViewButtonColumn();
            Smobiler.Core.Controls.TableViewTextBoxColumn tableViewTextBoxColumn2 = new Smobiler.Core.Controls.TableViewTextBoxColumn();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.tableView1 = new Smobiler.Core.Controls.TableView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.tableView2 = new Smobiler.Core.Controls.TableView();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "TableView";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
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
            this.tableView1,
            this.label1,
            this.tableView2,
            this.button1,
            this.button2,
            this.button3,
            this.button4});
            this.panel2.Location = new System.Drawing.Point(5, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 799);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "Columns设置列集合\r\nDataSource设置数据源\r\n";
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
            this.labTitle.Text = "表格控件";
            // 
            // tableView1
            // 
            this.tableView1.Border = new Smobiler.Core.Controls.Border(1F, 1F, 0F, 0F);
            this.tableView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            tableViewLabelColumn4.DataMember = "ID";
            tableViewLabelColumn4.DisplayMember = "NAME";
            tableViewLabelColumn4.HeaderText = "名称";
            tableViewLabelColumn5.DisplayMember = "Value";
            tableViewLabelColumn5.HeaderText = "数量";
            this.tableView1.Columns.AddRange(new Smobiler.Core.Controls.TableViewColumn[] {
            tableViewLabelColumn4,
            tableViewLabelColumn5});
            this.tableView1.Location = new System.Drawing.Point(90, 97);
            this.tableView1.Name = "tableView1";
            this.tableView1.Size = new System.Drawing.Size(101, 126);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 274);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 223);
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // tableView2
            // 
            this.tableView2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            tableViewLabelColumn6.DisplayMember = "ID";
            tableViewLabelColumn6.Text = "ID";
            tableViewButtonColumn2.DisplayMember = "NAME";
            tableViewButtonColumn2.HeaderText = "名称";
            tableViewTextBoxColumn2.DisplayMember = "Value";
            tableViewTextBoxColumn2.HeaderText = "数量";
            this.tableView2.Columns.AddRange(new Smobiler.Core.Controls.TableViewColumn[] {
            tableViewCheckBoxColumn2,
            tableViewLabelColumn6,
            tableViewButtonColumn2,
            tableViewTextBoxColumn2});
            this.tableView2.Location = new System.Drawing.Point(28, 524);
            this.tableView2.Name = "tableView2";
            this.tableView2.Size = new System.Drawing.Size(222, 126);
            this.tableView2.TextBoxCellTextChanged += new Smobiler.Core.Controls.TableViewTextBoxCellEventHandler(this.tableView2_TextBoxCellTextChanged);
            this.tableView2.TextBoxCellTouchEnter += new Smobiler.Core.Controls.TableViewTextBoxCellEventHandler(this.tableView2_TextBoxCellTouchEnter);
            this.tableView2.TextBoxCellTouchLeave += new Smobiler.Core.Controls.TableViewTextBoxCellEventHandler(this.tableView2_TextBoxCellTouchLeave);
            this.tableView2.ButtonCellLongPress += new Smobiler.Core.Controls.TableViewButtonCellEventHandler(this.tableView2_ButtonCellLongPress);
            this.tableView2.ButtonCellPress += new Smobiler.Core.Controls.TableViewButtonCellEventHandler(this.tableView2_ButtonCellPress);
            this.tableView2.CheckBoxCellCheckedChanged += new Smobiler.Core.Controls.TableViewCheckBoxCellEventHandler(this.tableView2_CheckBoxCellCheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.Text = "更改第三列Visible";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 682);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 35);
            this.button2.Text = "滚动到第6行";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 729);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 35);
            this.button3.Text = "增加新行";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 729);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 35);
            this.button4.Text = "移除最后一行";
            this.button4.Press += new System.EventHandler(this.button4_Press);
            // 
            // demoTableView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(300, 1500);
            this.Load += new System.EventHandler(this.demoTableView_Load);
            this.Name = "demoTableView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.TableView tableView1;
        private Core.Controls.Label label1;
        private Core.Controls.TableView tableView2;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
        private Core.Controls.Button button3;
        private Core.Controls.Button button4;
    }
}