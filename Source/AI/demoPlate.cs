using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Collections;

namespace Smobiler.Tutorials.AI
{
    partial class demoPlate : Smobiler.Core.Controls.MobileForm
    {
        private void btnIMC_Press(object sender, EventArgs e)
        {
            this.plate1.PlateSource = Smobiler.AI.PlateSource.Camera;
            plate1.Recognize();
        }

        private void btnIFCA_Press(object sender, EventArgs e)
        {
            this.plate1.PlateSource = Smobiler.AI.PlateSource.CameraAlbum;
            plate1.Recognize();
        }

        private void btnIFA_Press(object sender, EventArgs e)
        {
            this.plate1.PlateSource = Smobiler.AI.PlateSource.Album;
            plate1.Recognize(); 
        }

        private void plate1_Recognized(object sender, Smobiler.AI.PlateRecognizedEventArgs e)
        {
            if (e.isError == true)
                this.Toast(e.error);
            else if (e.Result.Length == 0)
            {
                this.Toast("Î´¼ì²âµ½³µÅÆ");
            }
            else
            { 
                List<string> number = new List<string>();
                for (int i = 0; i < e.Result.Length; i++)
                {
                    number.Add(e.Result[i].Number);
                }
                this.Toast(string.Join("/", number));
            }
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRC_Press(object sender, EventArgs e)
        {
            this.plate1.PlateSource = Smobiler.AI.PlateSource.RealtimeCapture;
            plate1.Recognize();
        }
    }
}