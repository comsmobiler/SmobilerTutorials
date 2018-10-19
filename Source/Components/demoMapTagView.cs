using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoMapTagView : Smobiler.Core.Controls.MobileForm
    {
        public demoMapTagView()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mapTagView1_Press(object sender, EventArgs e)
        {
            Toast("Press");
        }

        private void button1_Press(object sender, EventArgs e)
        {
            mapTagView1.Longitude =double.Parse(textBox1.Text);
            mapTagView1.Latitude = double.Parse(textBox2.Text);
            mapTagView1.Description = textBox3.Text;
        }
    }
}