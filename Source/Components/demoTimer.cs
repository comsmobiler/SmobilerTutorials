using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoTimer : Smobiler.Core.Controls.MobileForm
    {
        public demoTimer()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();          
        }
        private int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progress1.Value != 1)
                progress1.Value += 0.1f;
            else
                progress1.Value = 0;

            switch1.Checked = !switch1.Checked;

            checkBox1.Checked = !checkBox1.Checked;
            checkBox2.Checked = !checkBox2.Checked;

            label1.Text = i++.ToString();
        }

        private void demoTimer_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnstart_Press(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnstop_Press(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}