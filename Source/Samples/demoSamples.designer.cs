using Smobiler.Core;

namespace Smobiler.Tutorials.Samples
{
    partial class demoSamples : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public demoSamples()
            : base()
        {
            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.listMenuView1 = new Smobiler.Core.Controls.ListMenuView();
            // 
            // listMenuView1
            // 
            this.listMenuView1.Flex = 1;
            this.listMenuView1.Name = "listMenuView1";
            this.listMenuView1.Size = new System.Drawing.Size(0, 300);
            this.listMenuView1.ItemPress += new Smobiler.Core.Controls.ListMenuViewItemPressEventHandler(this.listMenuView1_ItemPress);
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listMenuView1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoSamples_Load);
            this.Name = "demoSamples";

        }
        #endregion

        private Smobiler.Core.Controls.ListMenuView listMenuView1;

    }
}