using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples.ShowDialog
{

    public delegate void DialogPasswordEventHandler(string password);

    //[System.ComponentModel.ToolboxItem(true)]
    partial class userDialogPassword : Smobiler.Core.Controls.MobileUserControl
    {

        private int currentPassNum = 0;

        public event DialogPasswordEventHandler DialogPassword;

        private void ibtClose_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnBack_Press(object sender, EventArgs e)
        {
            if (currentPassNum > 0)
            {
                //在点击删除时，删除界面上已经输入的数字
                Label labNum = this.palPassword.Controls.Find("labPass" + currentPassNum.ToString()) as Label;
                labNum.Text = "";
                currentPassNum -= 1;
            }
        }

        /// <summary>
        /// 通过此属性获取密码
        /// </summary>
        public string Password
        {
            get
            {
                return string.Format("{0}{1}{2}{3}{4}{5}", this.labPass1.Text, this.labPass2.Text, this.labPass3.Text, this.labPass4.Text, this.labPass5.Text, this.labPass6.Text);
            }
        }

        private void btnNum_Press(object sender, EventArgs e)
        {
            currentPassNum += 1;
            Button btn=sender as Button;
            //由于控件是从btnNum0到btnNum9，只需要取当前控件名的最后一位，作为数字即可。
            char num= btn.Name[6];
            //找到对应位置的Label并显示。
            Label labNum = this.palPassword.Controls.Find("labPass" + currentPassNum.ToString()) as Label;
            labNum.Text = num.ToString();
            //如果当前密码输入够6位，那么关闭当前界面。
            if (currentPassNum >=6)
            {
                if (DialogPassword != null) DialogPassword.Invoke(Password);
                this.Close();
            }
        }

        private void btnForgetPass_Press(object sender, EventArgs e)
        {
            MessageBox.Show("未实现");
        }
    }
}