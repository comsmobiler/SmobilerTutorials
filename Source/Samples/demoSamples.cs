using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Tutorials.Samples.AnimationDialog;
using Smobiler.Tutorials.Samples.Barcode;
using Smobiler.Tutorials.Samples.Layout;
using Smobiler.Tutorials.Samples.ListView;
using Smobiler.Tutorials.Samples.Speech;
using Smobiler.Tutorials.Samples.Transparent;
using Smobiler.Tutorials.Samples.WebView;

namespace Smobiler.Tutorials.Samples
{
    partial class demoSamples : Smobiler.Core.Controls.MobileForm
    {

        private void demoSamples_Load(object sender, EventArgs e)
        {
            //定义ListMenuViewGroup
            ListMenuViewGroup grp1 = new ListMenuViewGroup();
            grp1.Items.Add(new ListMenuViewItem("logon", "ListView服务端刷新", "", "") { Tag = "demoListViewRefresh" });
            grp1.Items.Add(new ListMenuViewItem("logon", "ListView模板更新 - 编辑界面", "", "") { Tag = "demoListViewUpdate" });
            grp1.Items.Add(new ListMenuViewItem("logon", "ListView删除行", "", "") { Tag = "demoListViewRemove" });
            grp1.Items.Add(new ListMenuViewItem("logon", "ListView行绑定", "", "") { Tag = "demoListViewRowBind" });
            grp1.Items.Add(new ListMenuViewItem("logon", "数据选择", "", "") { Tag = "userFilter" });
            grp1.Items.Add(new ListMenuViewItem("logon", "底部弹出输入Dialog", "", "") { Tag = "userFooterDialog" });
            grp1.Items.Add(new ListMenuViewItem("logon", "弹出密码输入框", "", "") { Tag = "userDialogPassword" });
            grp1.Items.Add(new ListMenuViewItem("logon", "带弹出效果的弹窗", "", "") { Tag = "AnimationDialog" });
            grp1.Items.Add(new ListMenuViewItem("logon", "ShowDialog后获取数据", "", "") { Tag = "demogetdata" });
            grp1.Items.Add(new ListMenuViewItem("logon", "WebView加载各种资源", "", "") { Tag = "demoWebView" });
            grp1.Items.Add(new ListMenuViewItem("logon", "Image动态加载图像", "", "") { Tag = "demoCustomResource" });

            grp1.Items.Add(new ListMenuViewItem("logon", "绝对布局", "", "") { Tag = "demoLoginAbsoluteLayout" });
            grp1.Items.Add(new ListMenuViewItem("logon", "相对布局", "", "") { Tag = "demoLoginRelativeLayout" });

            grp1.Items.Add(new ListMenuViewItem("logon", "透明度", "", "") { Tag = "demoTransparent" });

            grp1.Items.Add(new ListMenuViewItem("logon", "双向滚动", "", "") { Tag = "demoTwoWayScrolling" });
            grp1.Items.Add(new ListMenuViewItem("logon", "基于 TagPageView 的 Toolbar", "", "") { Tag = "demoTabToolbar" });
            grp1.Items.Add(new ListMenuViewItem("logon", "WebView控件和网页调用的示例", "", "") { Tag = "demoHtmlInteraction" });
            grp1.Items.Add(new ListMenuViewItem("logon", "服务端语音转文字示例", "", "") { Tag = "demoSpeech" });
            grp1.Items.Add(new ListMenuViewItem("logon", "服务端生成条码示例", "", "") { Tag = "demoBarcode" });



            //将ListMenuViewGroup添加到当前的ListMenuView中
            this.listMenuView1.Groups.Add(grp1);
        }

        //用于显示一个过滤的用户控件，详见FilterView文件夹
        userFilter filter;
        //用于Dialog弹出时的选项
        DialogOptions filterOptions;

        //用于显示在底部弹出的用户控件，详见ShowDialog文件夹
        Smobiler.Tutorials.Samples.ShowDialog.userFooterDialog footerDialog;
        //用于Dialog弹出时的选项
        DialogOptions footerDialogOptions;

        /// <summary>
        /// 处理ListMenuView的元素点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            switch (e.Item.Tag.ToString())
            {
                case "demoListViewRefresh":
                    //显示demoListViewRefresh窗体
                    this.Show(new demoListViewRefresh());
                    break;
                case "userFilter":
                    //Dialog显示的自定义控件，如果重复使用，不需要每一次都实例化，如果需要实例化，记得把原来的给Destroy
                    if (filter == null)
                    {
                        //由于内部使用了Flex布局，需要在外部给定高度
                        filter = new userFilter();
                        filter.Height = 400;
                        filter.BackColor = System.Drawing.Color.White;

                        /* DialogOptions参数说明
                         * justifyAlign: LayoutJustifyAlign.FlexEnd 布局显示在最下面
                         * backColor: System.Drawing.Color.FromArgb(128, 128, 128, 128) 整个Dialog的背景色
                         * padding: Padding.Empty 设置内边框为空，就是全屏显示
                         * touchClosed: true 是否点击空白处关闭
                         */
                        filterOptions = new DialogOptions(justifyAlign: LayoutJustifyAlign.FlexEnd, backColor: System.Drawing.Color.FromArgb(128, 128, 128, 128), padding: Padding.Empty, touchClosed: true);
                    }
                    //弹出filter
                    this.ShowDialog(filter, filterOptions);
                    break;
                case "userFooterDialog":
                    //Dialog显示的自定义控件，如果重复使用，不需要每一次都实例化，如果需要实例化，记得把原来的给Destroy
                    if (footerDialog == null)
                    {
                        //由于内部控件都有了高度，所以userFooterDialog不用设置高度，会自动撑大
                        footerDialog = new Smobiler.Tutorials.Samples.ShowDialog.userFooterDialog();

                        //同case "userFilter":中的参数设定
                        footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Padding.Empty, true);
                    }
                    //弹出footerDialog
                    this.ShowDialog(footerDialog, footerDialogOptions);
                    break;
                case "userDialogPassword":
                    if (footerDialogOptions == null)
                    {
                        //同case "userFilter":中的参数设定
                        footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Padding.Empty, true);
                    }
                    //创建userDialogPassword用户控件实例
                    ShowDialog.userDialogPassword dialogPassowrd = new ShowDialog.userDialogPassword();
                    //绑定DialogPassword事件
                    dialogPassowrd.DialogPassword += (pass) => { MessageBox.Show(pass); };
                    //弹出dialogPassowrd
                    this.ShowDialog(dialogPassowrd, footerDialogOptions);
                    break;
                case "demogetdata":
                    //创建demogetdata用户控件实例
                    demogetdata dm = new demogetdata();
                    //绑定demogetdata的Selected事件
                    dm.Selected += (obj, args) => { Toast(args.Text); };
                    //弹出Dialog
                    this.ShowDialog(dm);
                    break;
                case "demoWebView":
                    //显示demoWebView窗体
                    this.Show(new demoWebView());
                    break;
                case "demoCustomResource":
                    //显示demoCustomResource窗体
                    this.Show(new demoCustomResource());
                    break;
                case "demoLoginRelativeLayout":
                    //显示demoLoginRelativeLayout窗体
                    this.Show(new demoLoginRelativeLayout());
                    break;
                case "demoLoginAbsoluteLayout":
                    //显示demoLoginAbsoluteLayout窗体
                    this.Show(new demoLoginAbsoluteLayout());

                    break;
                case "demoTransparent":
                    //显示demoLoginAbsoluteLayout窗体
                    this.Show(new demoTransparent());
                    break;

                case "demoTwoWayScrolling":
                    //显示demoTwoWayScrolling窗体
                    this.Show(new demoTwoWayScrolling());
                    break;

                case "demoTabToolbar":
                    //显示demoTabToolbar窗体
                    this.Show(new demoTabToolbar());
                    break;

                case "demoHtmlInteraction":
                    //显示demoTabToolbar窗体
                    this.Show(new demoHtmlInteraction());
                    break;
                case "demoListViewUpdate":
                    this.Show(new demoListViewTemplateUpdate());
                    break;
                case "demoListViewRemove":
                    this.Show(new demoListViewRemove());
                    break;
                case "demoListViewRowBind":
                    this.Show(new demoListViewRowBind());
                    break;
                case "demoSpeech":
                    this.Show(new demoSpeech());
                    break;
                case "demoBarcode":
                    this.Show(new demoBarcode());
                    break;
                case "AnimationDialog":
                    this.ShowAnimationDialog(new animationDialog(),new AnimationDialogOptions() { 
                    SwipeToClose=false});
                    break;
            }
        }
    }
}