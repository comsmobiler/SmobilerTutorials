using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Tutorials.Components;
using Smobiler.Tutorials.Controls;
using Smobiler.Tutorials.Devices;
using Smobiler.Tutorials.Plugins;
using Smobiler.Tutorials.AI;

namespace Smobiler.Tutorials
{
    partial class demoControls : Smobiler.Core.Controls.MobileForm
    {
        public demoControls()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void demoControls_Load(object sender, EventArgs e)
        {
            //Basic Control
            IconMenuViewGroup grpBasic = new IconMenuViewGroup("基础控件");
            grpBasic.Items.Add(new IconMenuViewItem("Button", "Button") { Tag = typeof(demoButton) });
            grpBasic.Items.Add(new IconMenuViewItem("Label", "Label") { Tag = typeof(demoLabel) });
            grpBasic.Items.Add(new IconMenuViewItem("TextBox", "TextBox") { Tag = typeof(demoTextBox) });
            grpBasic.Items.Add(new IconMenuViewItem("CheckBox", "CheckBox") { Tag = typeof(demoCheckBox) });
            grpBasic.Items.Add(new IconMenuViewItem("Switch", "Switch") { Tag = typeof(demoSwitch) });
            grpBasic.Items.Add(new IconMenuViewItem("Image", "Image") { Tag = typeof(demoImage) });
            grpBasic.Items.Add(new IconMenuViewItem("FontIcon", "FontIcon") { Tag = typeof(demoFontIcon) });
            grpBasic.Items.Add(new IconMenuViewItem("ZoomImage", "ZoomImage") { Tag = typeof(demoZoomImage) });
            grpBasic.Items.Add(new IconMenuViewItem("Line", "Line") { Tag = typeof(demoLine) });
            grpBasic.Items.Add(new IconMenuViewItem("Slider", "Slider") { Tag = typeof(demoSlider) });
            grpBasic.Items.Add(new IconMenuViewItem("DatePicker", "DatePicker") { Tag = typeof(demoDatePicker) });
            grpBasic.Items.Add(new IconMenuViewItem("Calendar", "Calendar") { Tag = typeof(demoCalendar) });
            grpBasic.Items.Add(new IconMenuViewItem("Picker", "Picker") { Tag = typeof(demoPicker) });
            grpBasic.Items.Add(new IconMenuViewItem("Progress", "Progress") { Tag = typeof(demoProgress) });
            grpBasic.Items.Add(new IconMenuViewItem("Spinner", "Spinner") { Tag = typeof(demoSpinner) });
            grpBasic.Items.Add(new IconMenuViewItem("SegmentedControl", "SegmentedControl") { Tag = typeof(demoSegmentedControl) });
            grpBasic.Items.Add(new IconMenuViewItem("MapTagView", "MapTagView") { Tag = typeof(demoMapTagView) });
            grpBasic.Items.Add(new IconMenuViewItem("BarcodeView", "BarcodeView") { Tag = typeof(demoBarcodeView) });
            this.iconMenuView1.Groups.Add(grpBasic);

            //Container Control
            IconMenuViewGroup grpContainer = new IconMenuViewGroup("容器控件");
            grpContainer.Items.Add(new IconMenuViewItem("TouchablePanel", "TouchablePanel") { Tag = typeof(demoTouchablePanel) });
            grpContainer.Items.Add(new IconMenuViewItem("ScrollablePanel", "ScrollablePanel") { Tag = typeof(demoScrollablePanel) });
            grpContainer.Items.Add(new IconMenuViewItem("TabPageView", "TabPageView") { Tag = typeof(demoTabPageView) });
            this.iconMenuView1.Groups.Add(grpContainer);

            //Template Control
            IconMenuViewGroup grpTemplate = new IconMenuViewGroup("模板控件");
            grpTemplate.Items.Add(new IconMenuViewItem("PageView", "PageView") { Tag = typeof(demoPageView) });
            this.iconMenuView1.Groups.Add(grpTemplate);

            //Components
            IconMenuViewGroup grpComponent = new IconMenuViewGroup("组件");
            grpComponent.Items.Add(new IconMenuViewItem("Camera", "Camera") { Tag = typeof(demoCamera) });
            grpComponent.Items.Add(new IconMenuViewItem("BarCodeScanner", "BarCodeScanner") { Tag = typeof(demoBarCodeScanner) });
            grpComponent.Items.Add(new IconMenuViewItem("VoiceRecorder", "VoiceRecorder") { Tag = typeof(demoVoiceRecorder) });
            grpComponent.Items.Add(new IconMenuViewItem("GPS", "GPS") { Tag = typeof(demoGPS) });
            grpComponent.Items.Add(new IconMenuViewItem("Timer", "Timer") { Tag = typeof(demoTimer) });
            this.iconMenuView1.Groups.Add(grpComponent);

            //Chart Control
            IconMenuViewGroup grpChart = new IconMenuViewGroup("图表控件");
            grpChart.Items.Add(new IconMenuViewItem("LineChart", "LineChart") { Tag = typeof(demoLineChart) });
            grpChart.Items.Add(new IconMenuViewItem("BarChart", "BarChart") { Tag = typeof(demoBarChart) });
            grpChart.Items.Add(new IconMenuViewItem("PieChart", "PieChart") { Tag = typeof(demoPieChart) });
            grpChart.Items.Add(new IconMenuViewItem("BubbleChart", "BubbleChart") { Tag = typeof(demoBubbleChart) });
            grpChart.Items.Add(new IconMenuViewItem("RadarChart", "RadarChart") { Tag = typeof(demoRadarChart) });
            grpChart.Items.Add(new IconMenuViewItem("ScatterChart", "ScatterChart") { Tag = typeof(demoScatterChart) });
            grpChart.Items.Add(new IconMenuViewItem("CandleStickChart", "CandleStickChart") { Tag = typeof(demoCandleStickChart) });
            this.iconMenuView1.Groups.Add(grpChart);

            //Functions
            IconMenuViewGroup grpFunctions = new IconMenuViewGroup("功能");
            grpFunctions.Items.Add(new IconMenuViewItem("Client", "Client") { Tag = typeof(demoClient) });
            grpFunctions.Items.Add(new IconMenuViewItem("JPush", "JPush") { Tag = typeof(demoJPush) });
            this.iconMenuView1.Groups.Add(grpFunctions);

            //Controls
            IconMenuViewGroup grpControls = new IconMenuViewGroup("自定义控件");
            grpControls.Items.Add(new IconMenuViewItem("AlbumView", "AlbumView") { Tag = typeof(demoAlbumView) });
            grpControls.Items.Add(new IconMenuViewItem("IconMenuView", "IconMenuView") { Tag = typeof(demoIconMenuView) });
            grpControls.Items.Add(new IconMenuViewItem("ImageButton", "ImageButton") { Tag = typeof(demoImageButton) });
            grpControls.Items.Add(new IconMenuViewItem("ListMenuView", "ListMenuView") { Tag = typeof(demoListMenuView) });
            grpControls.Items.Add(new IconMenuViewItem("Numeric", "Numeric") { Tag = typeof(demoNumeric) });
            grpControls.Items.Add(new IconMenuViewItem("PopList", "PopList") { Tag = typeof(demoPopList) });
            grpControls.Items.Add(new IconMenuViewItem("RadioGroup", "RadioGroup") { Tag = typeof(demoRadioGroup) });
            grpControls.Items.Add(new IconMenuViewItem("RatingBar", "RatingBar") { Tag = typeof(demoRatingBar) });
            grpControls.Items.Add(new IconMenuViewItem("Title", "Title") { Tag = typeof(demoTitle) });
            grpControls.Items.Add(new IconMenuViewItem("ToolBar", "ToolBar") { Tag = typeof(demoToolBar) });
            this.iconMenuView1.Groups.Add(grpControls);

            //Plugins
            IconMenuViewGroup grpPlugins = new IconMenuViewGroup("插件");
            grpPlugins.Items.Add(new IconMenuViewItem("AliPay", "AliPay") { Tag = typeof(demoAliPay) });
            grpPlugins.Items.Add(new IconMenuViewItem("FingerPrint", "FingerPrint") { Tag = typeof(demoFingerPrint) });
            grpPlugins.Items.Add(new IconMenuViewItem("HTMLView", "HTMLView") { Tag = typeof(demoHTMLView) });
            
            grpPlugins.Items.Add(new IconMenuViewItem("LiveStream", "LiveStream") { Tag = typeof(demoLiveStream) });
            grpPlugins.Items.Add(new IconMenuViewItem("SignatureView", "SignatureView") { Tag = typeof(demoSignatureView) });
            grpPlugins.Items.Add(new IconMenuViewItem("WeiXin", "WeiXin") { Tag = typeof(demoWeiXin) });
            grpPlugins.Items.Add(new IconMenuViewItem("Bluetooth", "Bluetooth") { Tag = typeof(demoBluetooth) });
            grpPlugins.Items.Add(new IconMenuViewItem("ScanBarcodeView", "ScanBarcodeView") { Tag = typeof(demoScanBarcodeView) });

            grpPlugins.Items.Add(new IconMenuViewItem("Spinner", "MarqueeLabel") { Tag = typeof(demoMarqueeLabel) });
            grpPlugins.Items.Add(new IconMenuViewItem("AndroidCodeCompiler", "AndroidCodeCompiler") { Tag = typeof(demoAndroidCodeCompiler) });
            grpPlugins.Items.Add(new IconMenuViewItem("JsCodeCompiler", "JsCodeCompiler") { Tag = typeof(demoJsCodeCompiler) });
            grpPlugins.Items.Add(new IconMenuViewItem("BarcodeReader", "BarcodeReader") { Tag = typeof(demoBarcodeReader) });
            this.iconMenuView1.Groups.Add(grpPlugins);

            //Devices
            IconMenuViewGroup grpDevices = new IconMenuViewGroup("硬件");
            grpDevices.Items.Add(new IconMenuViewItem("R100", "R100") { Tag = typeof(demoR100) });
            grpDevices.Items.Add(new IconMenuViewItem("R200", "R200") { Tag = typeof(demoR200) });
            grpDevices.Items.Add(new IconMenuViewItem("R1000", "R1000") { Tag = typeof(demoR1000) });
            grpDevices.Items.Add(new IconMenuViewItem("R2000", "R2000") { Tag = typeof(demoR2000) });
            grpDevices.Items.Add(new IconMenuViewItem("TC25", "TC25") { Tag = typeof(demoTC25) });
            grpDevices.Items.Add(new IconMenuViewItem("V7000", "V7000") { Tag = typeof(demoV7000) });
            grpDevices.Items.Add(new IconMenuViewItem("P380", "P380") { Tag = typeof(demoP380) });
            grpDevices.Items.Add(new IconMenuViewItem("S5000", "S5000") { Tag = typeof(demoS5000) });
            grpDevices.Items.Add(new IconMenuViewItem("N800", "N800") { Tag = typeof(demoN800) });
            grpDevices.Items.Add(new IconMenuViewItem("HMT1", "HMT1") { Tag = typeof(demoHMT1) });

            this.iconMenuView1.Groups.Add(grpDevices);


            //AI
            IconMenuViewGroup grpAI = new IconMenuViewGroup("AI");
            grpAI.Items.Add(new IconMenuViewItem("Plate", "Plate") { Tag = typeof(demoPlate) });
            grpAI.Items.Add(new IconMenuViewItem("Speech", "Speech") { Tag = typeof(demoSpeech) });
            this.iconMenuView1.Groups.Add(grpAI);
        }

        private void iconMenuView1_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            MobileForm demoForm = Activator.CreateInstance((Type)e.Item.Tag) as MobileForm;
            this.Show(demoForm);
        }
    }
}