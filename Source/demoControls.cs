using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
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
            //Plugins
            IconMenuViewGroup grpPlugins = new IconMenuViewGroup("插件");
            grpPlugins.Items.Add(new IconMenuViewItem("LiveStream", "LiveStream") { Tag = typeof(demoLiveStream) });
            this.iconMenuView1.Groups.Add(grpPlugins);

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