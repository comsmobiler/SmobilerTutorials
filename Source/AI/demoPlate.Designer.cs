using Smobiler.Core;

namespace Smobiler.Tutorials.AI
{
    partial class demoPlate : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public demoPlate()
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
            this.plate1 = new Smobiler.AI.Plate();
            this.btnIMC = new Smobiler.Core.Controls.Button();
            this.btnIFCA = new Smobiler.Core.Controls.Button();
            this.btnIFA = new Smobiler.Core.Controls.Button();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.btnRC = new Smobiler.Core.Controls.Button();
            // 
            // plate1
            // 
            this.plate1.IsUploadFailResource = true;
            this.plate1.Name = "plate1";
            this.plate1.Recognized += new Smobiler.AI.PlateRecognizedEventHandler(this.plate1_Recognized);
            // 
            // btnIMC
            // 
            this.btnIMC.Location = new System.Drawing.Point(38, 98);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(228, 30);
            this.btnIMC.Text = "imageFromCamera";
            this.btnIMC.Press += new System.EventHandler(this.btnIMC_Press);
            // 
            // btnIFCA
            // 
            this.btnIFCA.Location = new System.Drawing.Point(38, 181);
            this.btnIFCA.Name = "btnIFCA";
            this.btnIFCA.Size = new System.Drawing.Size(228, 30);
            this.btnIFCA.Text = "imageFromCameraAlbum";
            this.btnIFCA.Press += new System.EventHandler(this.btnIFCA_Press);
            // 
            // btnIFA
            // 
            this.btnIFA.Location = new System.Drawing.Point(38, 259);
            this.btnIFA.Name = "btnIFA";
            this.btnIFA.Size = new System.Drawing.Size(228, 30);
            this.btnIFA.Text = "imageFromAlbum";
            this.btnIFA.Press += new System.EventHandler(this.btnIFA_Press);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Plate";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnRC
            // 
            this.btnRC.Location = new System.Drawing.Point(38, 330);
            this.btnRC.Name = "btnRC";
            this.btnRC.Size = new System.Drawing.Size(228, 30);
            this.btnRC.Text = "RealtimeCapture";
            this.btnRC.Press += new System.EventHandler(this.btnRC_Press);
            // 
            // demoPlate
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.plate1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnIMC,
            this.btnIFCA,
            this.btnIFA,
            this.btnRC});
            this.Name = "demoPlate";

        }
        #endregion

        private Smobiler.AI.Plate plate1;
        private Smobiler.Core.Controls.Button btnIMC;
        private Smobiler.Core.Controls.Button btnIFCA;
        private Smobiler.Core.Controls.Button btnIFA;
        private Core.Controls.Title title1;
        private Core.Controls.Button btnRC;
    }
}