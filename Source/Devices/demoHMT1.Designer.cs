using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoHMT1 : Smobiler.Core.Controls.MobileForm
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
            this.btnSynthesis = new Smobiler.Core.Controls.Button();
            this.btnSetCommands = new Smobiler.Core.Controls.Button();
            this.btnRestoreCommands = new Smobiler.Core.Controls.Button();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.hmT11 = new Smobiler.Device.HMT1();
            // 
            // btnSynthesis
            // 
            this.btnSynthesis.Location = new System.Drawing.Point(68, 97);
            this.btnSynthesis.Name = "btnSynthesis";
            this.btnSynthesis.Size = new System.Drawing.Size(142, 30);
            this.btnSynthesis.Text = "语音合成";
            this.btnSynthesis.Press += new System.EventHandler(this.btnSynthesis_Press);
            // 
            // btnSetCommands
            // 
            this.btnSetCommands.Location = new System.Drawing.Point(68, 165);
            this.btnSetCommands.Name = "btnSetCommands";
            this.btnSetCommands.Size = new System.Drawing.Size(142, 30);
            this.btnSetCommands.Text = "设置指令";
            this.btnSetCommands.Press += new System.EventHandler(this.btnSetCommands_Press);
            // 
            // btnRestoreCommands
            // 
            this.btnRestoreCommands.Location = new System.Drawing.Point(68, 230);
            this.btnRestoreCommands.Name = "btnRestoreCommands";
            this.btnRestoreCommands.Size = new System.Drawing.Size(142, 30);
            this.btnRestoreCommands.Text = "重置指令";
            this.btnRestoreCommands.Press += new System.EventHandler(this.btnRestoreCommands_Press);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "HMT1";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 35);
            this.label1.Text = "播放文字内容";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 35);
            this.label2.Text = "注册语音识别词";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 35);
            this.label3.Text = "清空语音识别词";
            // 
            // hmT11
            // 
            this.hmT11.Name = "hmT11";
            // 
            // demoHMT1
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.hmT11});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSynthesis,
            this.btnSetCommands,
            this.btnRestoreCommands,
            this.title1,
            this.label1,
            this.label2,
            this.label3});
            this.Load += new System.EventHandler(this.demoHMT1_Load);
            this.Name = "demoHMT1";

        }
        #endregion

        private Core.Controls.Button btnSynthesis;
        private Core.Controls.Button btnSetCommands;
        private Core.Controls.Button btnRestoreCommands;
        private Core.Controls.Title title1;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Device.HMT1 hmT11;
    }
}