using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Components
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class DragTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        public DragTemplate() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }
    }
}