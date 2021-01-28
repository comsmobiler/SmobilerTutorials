using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoDropdownAert : Smobiler.Core.Controls.MobileForm
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
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            this.dropdownAlert1 = new Smobiler.Plugins.DropdownAlert();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "DropDownAlert";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
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
            this.spinner1});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 319);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.White;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 89);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 99);
            this.labContent.Text = "Type获取与设置显示alert的类型(可设置success，custom，error，info，warn)；\r\nTitleNumOfLines获取与设置标题栏的" +
    "行数；\r\nTitle获取与设置标题行文本内容；\r\nCloseInterval获取与设置alert显示时间（毫秒）。";
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
            this.labTitle.Text = "下拉提醒组件";
            // 
            // spinner1
            // 
            this.spinner1.Items = new string[] {
        "Title",
        "TitleNumOfLines",
        "Message",
        "MessageNumOfLines",
        "CloseInterval",
        "CustomColor",
        "CustomImage",
        "ErrorColor",
        "InfoColor",
        "SuccessColor",
        "WarnColor",
        "显示sucess提示框",
        "显示error提示框",
        "显示info提示框",
        "显示warning提示框",
        "显示Custom提示框"};
            this.spinner1.Location = new System.Drawing.Point(17, 43);
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(247, 30);
            this.spinner1.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner1_ItemSelected);
            // 
            // dropdownAlert1
            // 
            this.dropdownAlert1.Name = "dropdownAlert1";
            this.dropdownAlert1.WarnColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(133)))), ((int)(((byte)(63)))));
            // 
            // demoDropdownAert
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.dropdownAlert1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoDropdownAert";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Spinner spinner1;
        private Smobiler.Plugins.DropdownAlert dropdownAlert1;
    }
}