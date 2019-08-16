using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoNFC : Smobiler.Core.Controls.MobileForm
    {
        public demoNFC() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private void btnstart_Press(object sender, EventArgs e)
        {
            try
            {
                nfc1.Start((obj, args) =>
                {
                    if (args.isError == true)
                    {
                        MessageBox.Show(args.error);
                    }
                    else
                    {
                        Toast("success");
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnissupported_Press(object sender, EventArgs e)
        {
            nfc1.IsSupported("MifareClassic", (obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success");
                }
            });
        }

        private void btnregisterTagEvent_Press(object sender, EventArgs e)
        {
            nfc1.RegisterTagEvent(false, 0, (obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success");
                }
            });
        }

        private void btnunregisterTagEvent_Press(object sender, EventArgs e)
        {
            nfc1.UnregisterTagEvent((obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success");
                }
            });
        }

        private void btngoToNfcSetting_Press(object sender, EventArgs e)
        {
            nfc1.GoToNfcSetting((obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success");
                }
            });
        }

        private void btngetLaunchTagEvent_Press(object sender, EventArgs e)
        {
            nfc1.GetLaunchTagEvent((obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success" + args.Result);
                }
            });
        }

        private void btnIsEnabled_Press(object sender, EventArgs e)
        {
            nfc1.IsEnabled((obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success");
                }
            });
        }

        private void btnmifareUltralightReadPages_Press(object sender, EventArgs e)
        {
            nfc1.MifareUltralightReadPages(0, (obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success" + args.Result);
                }
            });
        }

        private void btnrequestTechnology_Press(object sender, EventArgs e)
        {
            nfc1.RequestTechnology("MifareClassic", (obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success");
                }
            });
        }

        private void btncancelTechnologyRequest_Press(object sender, EventArgs e)
        {
            nfc1.CancelTechnologyRequest((obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success");
                }
            });
        }

        private void btncloseTechnology_Press(object sender, EventArgs e)
        {
            nfc1.CloseTechnology((obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success");
                }
            });
        }

        private void btngetTag_Press(object sender, EventArgs e)
        {
            nfc1.GetTag((obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success" + args.Result);
                }
            });
        }

        private void btngetCachedNdefMessage_Press(object sender, EventArgs e)
        {
            nfc1.GetCachedNdefMessage((obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success" + args.Result);
                }
            });
        }

        private void btngetNdefMessage_Press(object sender, EventArgs e)
        {
            nfc1.GetNdefMessage((obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success" + args.Result);
                }
            });
        }

        private void btnwriteNdefMessage_Press(object sender, EventArgs e)
        {
            byte[] ary1 = { 72, 101, 108, 108, 111, 44, 32, 119, 111, 114, 108, 100, 33, 0, 0, 0 };
            nfc1.WriteNdefMessage(ary1, (obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success");
                }
            });
        }

        private void demoNFC_Load(object sender, EventArgs e)
        {
            //this.Client.HeartBeatEnable(2000, null, (obj, args) =>
            //{
            //    if (args.isError == true)
            //    {
            //        Toast("网络断开");
            //    }
            //    else
            //    {
            //        Toast("心跳检测成功");
            //    }
            //});
        }

        private void btnMifareClassicReadBlock_Press(object sender, EventArgs e)
        {
            byte[] ary = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            nfc1.MifareClassicReadBlock(int.Parse(textBox2.Text), 0, ary, (obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success" + args.Result);
                }
            });
        }

        private void btnMifareClassicReadSector_Press(object sender, EventArgs e)
        {
            byte[] ary = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            nfc1.MifareClassicReadSector(int.Parse(textBox1.Text), ary, (obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success" + args.Result);
                }
            });
        }

        private void btnMifareClassicWriteBlock_Press(object sender, EventArgs e)
        {
            byte[] ary = { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF };
            byte[] ary1 = { 72, 101, 108, 108, 111, 44, 32, 119, 111, 114, 108, 100, 33, 0, 0, 0 };
            nfc1.MifareClassicWriteBlock(int.Parse(textBox1.Text), ary1, 0, ary, (obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success" + args.Result);
                }
            });
        }

        private void nfc1_NdefWrite(object sender, Smobiler.Plugins.NdefWriteEventArgs e)
        {
            Toast(e.State.ToString());
        }

        private void nfc1_NFCState(object sender, Smobiler.Plugins.NFCStateEventArgs e)
        {
            Toast(e.State.ToString());
        }

        private void nfc1_NFCTag(object sender, Smobiler.Plugins.NFCTagEventArgs e)
        {
            Toast(e.NFCTag.ToString());
        }

        private void nfc1_RequestTech(object sender, Smobiler.Plugins.RequestTechEventArgs e)
        {
            Toast(e.State.ToString());
        }

        private void btnmifareClassicGetSectorCount_Press(object sender, EventArgs e)
        {
            nfc1.MifareClassicGetSectorCount((obj, args) => {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("success" + args.Result);
                }
            });
        }
    }
}