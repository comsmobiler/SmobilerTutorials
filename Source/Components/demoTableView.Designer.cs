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
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn1 = new Smobiler.Core.Controls.TableViewLabelColumn();
            Smobiler.Core.Controls.TableViewLabelColumn tableViewLabelColumn2 = new Smobiler.Core.Controls.TableViewLabelColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(demoTableView));
            Smobiler.Core.Controls.TableViewCheckBoxColumn tableViewCheckBoxColumn1 = new Smobiler.Core.Controls.TableViewCheckBoxColumn();
            Smobiler.Core.Controls.TableViewButtonColumn tableViewButtonColumn1 = new Smobiler.Core.Controls.TableViewButtonColumn();
            Smobiler.Core.Controls.TableViewTextBoxColumn tableViewTextBoxColumn1 = new Smobiler.Core.Controls.TableViewTextBoxColumn();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.tableView1 = new Smobiler.Core.Controls.TableView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.tableView2 = new Smobiler.Core.Controls.TableView();
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
            this.tableView2});
            this.panel2.Location = new System.Drawing.Point(5, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 729);
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
            tableViewLabelColumn1.DataMember = "ID";
            tableViewLabelColumn1.DisplayMember = "NAME";
            tableViewLabelColumn1.HeaderText = "名称";
            tableViewLabelColumn2.DisplayMember = "Value";
            tableViewLabelColumn2.HeaderText = "数量";
            this.tableView1.Columns.AddRange(new Smobiler.Core.Controls.TableViewColumn[] {
            tableViewLabelColumn1,
            tableViewLabelColumn2});
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
            this.tableView2.Border = new Smobiler.Core.Controls.Border(1F, 1F, 0F, 0F);
            this.tableView2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            tableViewButtonColumn1.DisplayMember = "NAME";
            tableViewButtonColumn1.HeaderText = "名称";
            tableViewTextBoxColumn1.DisplayMember = "Value";
            tableViewTextBoxColumn1.HeaderText = "数量";
            this.tableView2.Columns.AddRange(new Smobiler.Core.Controls.TableViewColumn[] {
            tableViewCheckBoxColumn1,
            tableViewButtonColumn1,
            tableViewTextBoxColumn1});
            this.tableView2.Location = new System.Drawing.Point(70, 524);
            this.tableView2.Name = "tableView2";
            this.tableView2.Size = new System.Drawing.Size(151, 126);
            this.tableView2.TextBoxCellTextChanged += new Smobiler.Core.Controls.TableViewTextBoxCellEventHandler(this.tableView2_TextBoxCellTextChanged);
            this.tableView2.TextBoxCellTouchEnter += new Smobiler.Core.Controls.TableViewTextBoxCellEventHandler(this.tableView2_TextBoxCellTouchEnter);
            this.tableView2.TextBoxCellTouchLeave += new Smobiler.Core.Controls.TableViewTextBoxCellEventHandler(this.tableView2_TextBoxCellTouchLeave);
            this.tableView2.ButtonCellLongPress += new Smobiler.Core.Controls.TableViewButtonCellEventHandler(this.tableView2_ButtonCellLongPress);
            this.tableView2.ButtonCellPress += new Smobiler.Core.Controls.TableViewButtonCellEventHandler(this.tableView2_ButtonCellPress);
            this.tableView2.CheckBoxCellCheckedChanged += new Smobiler.Core.Controls.TableViewCheckBoxCellEventHandler(this.tableView2_CheckBoxCellCheckedChanged);
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
    }
}