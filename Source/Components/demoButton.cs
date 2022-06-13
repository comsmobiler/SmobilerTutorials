using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoButton : Smobiler.Core.Controls.MobileForm
    {
        public demoButton()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPress_Press(object sender, EventArgs e)
        {
            MessageBox.Show("点击事件被触发");
        }

        private void btnLongPress_LongPress(object sender, EventArgs e)
        {
            MessageBox.Show("长按事件被触发");
        }

        private void spinner1_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            switch (e.Item)
            {
                case "FontSize - 13":
                    this.button1.FontSize = 13f;
                    break;
                case "FontSize - 20":
                    this.button1.FontSize = 20f;
                    break;
                case "ForeColor - Red":
                    this.button1.ForeColor = System.Drawing.Color.Red;
                    break;
                case "ForeColor - Yellow":
                    this.button1.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case "Text - CurrentDate":
                    this.button1.Text = DateTime.Now.ToString();
                    break;
                case "HorizontalAlignment - Left":
                    this.button1.HorizontalAlignment = HorizontalAlignment.Left;
                    break;
                case "HorizontalAlignment - Center":
                    this.button1.HorizontalAlignment = HorizontalAlignment.Center;
                    break;
                case "HorizontalAlignment - Right":
                    this.button1.HorizontalAlignment = HorizontalAlignment.Right;
                    break;
                case "Shadow":
                    this.button1.Shadow = 3;
                    break;
            }
        }

          }
}