using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.ComponentModel;

namespace Smobiler.Tutorials.Samples
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class demogetdataTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        
        private void panel1_Press(object sender, EventArgs e)
        {
            
            demogetdata dmd = (demogetdata)this.Owner.Owner;
            dmd.OnSelected(this.label1.Text);
        }
        
    }

    /// <summary>
    /// 为Selected事件提供数据
    /// </summary>
    /// <remarks></remarks>
    public class SelectedEventArgs : EventArgs
    {

        private string _text = "";
        /// <summary>
        /// 选择的内容
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">选择的内容</param>
        /// <remarks></remarks>
        public SelectedEventArgs(string text) : base()
        {
            _text = text;
        }
    }

    /// <summary>
    /// 一个委托，它表示在按钮点击时要调用的方法。
    /// </summary>
    /// <param name="sender">事件源</param>
    /// <param name="e">包含事件数据的 SelectedEventArgs</param>
    /// <remarks></remarks>
    public delegate void SelectedEventHandler(object sender, SelectedEventArgs e);
}