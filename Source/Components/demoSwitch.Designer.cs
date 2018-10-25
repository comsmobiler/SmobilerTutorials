using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoSwitch : Smobiler.Core.Controls.MobileForm
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
            this.panel10 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.switch1 = new Smobiler.Core.Controls.Switch();
            this.switch2 = new Smobiler.Core.Controls.Switch();
            this.switch3 = new Smobiler.Core.Controls.Switch();
            this.switch4 = new Smobiler.Core.Controls.Switch();
            this.switch5 = new Smobiler.Core.Controls.Switch();
            this.switch6 = new Smobiler.Core.Controls.Switch();
            this.switch7 = new Smobiler.Core.Controls.Switch();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Swith";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2});
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 30);
            this.panel10.Name = "panel10";
            this.panel10.Scrollable = true;
            this.panel10.Size = new System.Drawing.Size(300, 970);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.BorderRadius = 5;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.switch1,
            this.switch2,
            this.switch3,
            this.switch4,
            this.switch5,
            this.switch6});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 179);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "开关控件，基础控件，Checked、Enabled、CircleColor、CheckedColor、UnCheckedColor属性设置不同样式";
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
            this.labTitle.Text = "不同样式的开关控件";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.label6,
            this.switch7});
            this.panel2.Location = new System.Drawing.Point(5, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 133);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(0, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 54);
            this.label5.Text = "CheckedChanged在选择改变时发生";
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
            this.label6.Text = "开关控件事件";
            // 
            // switch1
            // 
            this.switch1.Location = new System.Drawing.Point(21, 89);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(70, 30);
            // 
            // switch2
            // 
            this.switch2.Checked = true;
            this.switch2.Location = new System.Drawing.Point(21, 135);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(70, 30);
            // 
            // switch3
            // 
            this.switch3.CircleColor = System.Drawing.Color.DimGray;
            this.switch3.Location = new System.Drawing.Point(113, 89);
            this.switch3.Name = "switch3";
            this.switch3.Size = new System.Drawing.Size(70, 30);
            this.switch3.UnCheckedColor = System.Drawing.Color.Red;
            // 
            // switch4
            // 
            this.switch4.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.switch4.Location = new System.Drawing.Point(113, 135);
            this.switch4.Name = "switch4";
            this.switch4.Size = new System.Drawing.Size(70, 30);
            this.switch4.UnCheckedColor = System.Drawing.Color.Green;
            // 
            // switch5
            // 
            this.switch5.Enabled = false;
            this.switch5.Location = new System.Drawing.Point(205, 89);
            this.switch5.Name = "switch5";
            this.switch5.Size = new System.Drawing.Size(70, 30);
            this.switch5.UnCheckedColor = System.Drawing.Color.Red;
            // 
            // switch6
            // 
            this.switch6.Checked = true;
            this.switch6.Enabled = false;
            this.switch6.Location = new System.Drawing.Point(205, 135);
            this.switch6.Name = "switch6";
            this.switch6.Size = new System.Drawing.Size(70, 30);
            // 
            // switch7
            // 
            this.switch7.Location = new System.Drawing.Point(111, 93);
            this.switch7.Name = "switch7";
            this.switch7.Size = new System.Drawing.Size(70, 30);
            this.switch7.CheckedChanged += new System.EventHandler(this.switch7_CheckedChanged);
            // 
            // demoSwitch
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Name = "demoSwitch";
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoSwitch";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label5;
        private Core.Controls.Label label6;
        private Core.Controls.Switch switch1;
        private Core.Controls.Switch switch2;
        private Core.Controls.Switch switch3;
        private Core.Controls.Switch switch4;
        private Core.Controls.Switch switch5;
        private Core.Controls.Switch switch6;
        private Core.Controls.Switch switch7;
    }
}