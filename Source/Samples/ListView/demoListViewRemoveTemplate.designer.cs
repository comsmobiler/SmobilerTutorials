using System;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples
{
    partial class demoListViewRemoveTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public demoListViewRemoveTemplate()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnRemove = new Smobiler.Core.Controls.Button();
            this.btnChangeLabel = new Smobiler.Core.Controls.Button();
            this.checkBox1 = new Smobiler.Core.Controls.CheckBox();
            // 
            // label1
            // 
            this.label1.DisplayMember = "label";
            this.label1.Flex = 1;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 0);
            this.label1.Text = "label1";
            // 
            // btnRemove
            // 
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(79, 0);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Press += new System.EventHandler(this.btnRemove_Press);
            // 
            // btnChangeLabel
            // 
            this.btnChangeLabel.Name = "btnChangeLabel";
            this.btnChangeLabel.Size = new System.Drawing.Size(79, 0);
            this.btnChangeLabel.Text = "ChangeLabel";
            this.btnChangeLabel.Press += new System.EventHandler(this.btnChangeLabel_Press);
            // 
            // checkBox1
            // 
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 0);
            this.checkBox1.Style = Smobiler.Core.Controls.CheckBoxStyle.Circular;
            this.checkBox1.Visible = false;
            // 
            // demoListViewRemoveTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.btnRemove,
            this.btnChangeLabel,
            this.checkBox1});
            this.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoListViewRemoveTemplate";
        }
        #endregion

        private Label label1;
        private Button btnRemove;
        private Button btnChangeLabel;
        private CheckBox checkBox1;
    }
}