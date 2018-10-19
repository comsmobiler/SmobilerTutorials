using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoClient : Smobiler.Core.Controls.MobileForm
    {
        public demoClient()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoClient_Load(object sender, EventArgs e)
        {
            ListMenuViewGroup g1 = new ListMenuViewGroup();
            g1.Title = "手势";
            g1.ShowTitle = true;
            g1.AddItem("logon", "创建手势", "PatternCreate", "");
            g1.AddItem("logon", "本地验证手势", "PatternVerifyLocal", "");
            g1.AddItem("logon", "服务端验证手势", "PatternVerifyServer", "");
            ListMenuViewGroup g2 = new ListMenuViewGroup();
            g2.Title = "分享";
            g2.ShowTitle = true;
            g2.AddItem("logon", "分享文本", "ShareText", "");
            g2.AddItem("logon", "分享地址", "ShareURL", "");
            ListMenuViewGroup g3 = new ListMenuViewGroup();
            g3.Title = "通讯录";
            g3.ShowTitle = true;
            g3.AddItem("logon", "显示通讯录", "ContactsShow", "");
            g3.AddItem("logon", "添加通讯录", "ContactsAdd", "");
            g3.AddItem("logon", "获取通讯录", "ContactsGet", "");
            ListMenuViewGroup g4 = new ListMenuViewGroup();
            g4.Title = "资源";
            g4.ShowTitle = true;
            g4.AddItem("logon", "资源加载", "ResourceLoad", "");
            g4.AddItem("logon", "资源获取(所有包含c的资源）", "ResourceGet", "");
            g4.AddItem("logon", "资源删除（1.png,2.png,3.png）", "ResourceRemoveIDS", "");
            g4.AddItem("logon", "资源删除（所有包含c的资源）", "ResourceRemove", "");
            ListMenuViewGroup g5 = new ListMenuViewGroup();
            g5.Title = "文件";
            g5.ShowTitle = true;
            g5.AddItem("logon", "文件下载", "FileDownload", "");
            g5.AddItem("logon", "文件删除", "FileDelete", "");
            g5.AddItem("logon", "文件打开", "FileOpen", "");
            g5.AddItem("logon", "文件列表", "FileList", "");
            g5.AddItem("logon", "文件是否存在", "FileExists", "");
            g5.AddItem("logon", "文件上传", "FileUpload", "");
            ListMenuViewGroup g6 = new ListMenuViewGroup();
            g6.Title = "数据库";
            g6.ShowTitle = true;
            g6.AddItem("logon", "打开数据库", "OpenDataBase", "");
            g6.AddItem("logon", "设置数据库", "SetDataBase", "");
            g6.AddItem("logon", "获取数据库", "GetDataBase", "");
            g6.AddItem("logon", "关闭数据库", "CloseDataBase", "");
            g6.AddItem("logon", "删除数据库", "DeleteDataBase", "");
            ListMenuViewGroup g7 = new ListMenuViewGroup();
            g7.Title = "关于页";
            g7.ShowTitle = true;
            g7.AddItem("logon", "显示权限页", "ShowPermission", "");
            g7.AddItem("logon", "显示离线资源页", "ShowOfflineResources", "");
            g7.AddItem("logon", "显示网络诊断页", "ShowNetworkDiagnosis", "");
            g7.AddItem("logon", "显示关于页", "ShowAbout", "");
            ListMenuViewGroup g8 = new ListMenuViewGroup();
            g8.Title = "其他";
            g8.ShowTitle = true;
            g8.AddItem("logon", "获取当前网络类型", "GetNetWorkType", "");
            g8.AddItem("logon", "获取状态栏高度", "GetStatusbarHeight",  "");
            g8.AddItem("logon", "播放音频", "PlayAudio", "");
            g8.AddItem("logon", "停止播放音频", "StopAudio", "");
            g8.AddItem("logon", "发送邮件", "SendEmail", "");
            g8.AddItem("logon", "发送短信", "SendSMS", "");
            g8.AddItem("logon", "打电话", "TelCall", "");
            g8.AddItem("logon", "判断蓝牙", "IsOpenBlue", "");
            g8.AddItem("logon", "打开蓝牙", "OpenBlue", "");
            g8.AddItem("logon", "获取粘贴板内容", "GetClipboard", "");
            g8.AddItem("logon", "设置粘贴板内容", "SetClipBoard", "");
            g8.AddItem("logon", "清除缓存", "ClearCache", "");
            ListMenuViewGroup g9 = new ListMenuViewGroup();
            g9.Title = "客户端信息";
            g9.ShowTitle = true;
            g9.AddItem("logon", "获取客户端内核版本号", "CoreVersion", "");
            g9.AddItem("logon", "获取客户端设备名称", "Device", "");
            g9.AddItem("logon", "获取设备编号", "DeviceID", "");
            g9.AddItem("logon", "获取客户端操作系统类型", "DeviceOS", "");
            g9.AddItem("logon", "获取客户端操作系统版本号", "DeviceOSVersion", "");
            g9.AddItem("logon", "获取和设置一个值，该值表示是否启用客户端界面栈", "EnableStackView", "");
            g9.AddItem("logon", "获取客户端网络端点", "IPEndPoint", "");
            g9.AddItem("logon", "获取客户端最后一次操作时间", "LastDate", "");
            g9.AddItem("logon", "获取设备屏幕密度", "ScreenDensity", "");
            g9.AddItem("logon", "获取设备屏幕分辨率", "ScreenSize", "");
            g9.AddItem("logon", "获取客户端会话编号", "SessionID", "");
            g9.AddItem("logon", "获取客户端第一次连接时间", "StartDate", "");
            g9.AddItem("logon", "获取和设置用户会话编号", "UserSessionID", "");
            g9.AddItem("logon", "获取客户端版本号", "Version", "");
            g9.AddItem("logon", "关闭客户端", "Exit", "");
            g9.AddItem("logon", "关闭客户端并终止服务端会话", "ExitAndQuit", "");

            listMenuView1.Groups.AddRange((new ListMenuViewGroup[] { g1, g2, g3,g4,g5,g6,g7,g8,g9 }));
        }

        string clientPath = "";
        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            switch (e.Item.SubContent)
            {
                case "PatternCreate":
                    this.Client.Pattern.Create((obj, args) =>
                    {
                        if (args.isError == true)
                            Toast(args.error);
                        else
                        {
                            this.Client.Pattern.Password = args.Password;
                            Toast(args.Password);
                        }
                    });
                    break;
                case "PatternVerifyLocal":

                    this.Client.Pattern.VerifyLocal((obj, args) =>
                    {
                        if (args.isError == true)
                            Toast(args.error);
                        else
                            Toast("Sucess");
                    });
                    break;
                case "PatternVerifyServer":
                    this.Client.Pattern.VerifyServer((obj, args) =>
                    {
                        if (args.isError == true)
                            Toast(args.error);
                        else
                            Toast(args.Password);
                    });
                    break;
                case "ShareText":
                    this.Client.Share.SendText("这是从测试系统发出的测试");
                    break;
                case "ShareURL":
                    this.Client.Share.SendURL("http://www.smobiler.com");
                    break;
                case "ContactsShow":
                    this.Client.Contacts.Show();
                    break;
                case "ContactsAdd":
                    this.Client.Contacts.Add("smobiler", "18888888888", "smobiler@smobiler.com");
                    break;
                case "ContactsGet":
                    this.Client.Contacts.GetContactEnties((obj, args) =>
                    {
                        if (args.isError == true)
                        {
                            MessageBox.Show(args.error);
                        }
                        else
                        {
                            MessageBox.Show(string.Format("共计：{0}", args.Value.Count));
                        }
                    });
                    break;
                case "ResourceLoad":
                    this.Client.Resource.Load(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources.zip"), (obj, args) =>
                    {
                        if (args.isError == true)
                            Toast(args.error);
                        else
                            Toast("Done");
                    });
                    break;
                case "ResourceGet":
                    this.Client.Resource.Get(new Smobiler.Core.RPC.ClientResourceFilter("*c*", ""), (obj, args) =>
                    {
                        if (args.isError == true)
                            Toast(args.error);
                        else
                        {
                            List<string> list = new List<string>();
                            foreach (Smobiler.Core.RPC.ClientResourceArgs.ResourceData data in args.Resouces)
                            {
                                list.Add(string.Format("{0}/{1}/{2}", data.ResourceID, data.ResourceSize, data.ResourceDate));
                            }
                            MessageBox.Show(string.Format("数量{0}\r\n{1}", args.Count, string.Join("\r\n", list.ToArray())));
                        }
                    });
                    break;
                case "ResourceRemoveIDS":
                    this.Client.Resource.Remove(new string[] { "1.png", "2.png", "3.png" }, MobileResourceManager.DefaultImageResourceName, (obj, args) =>
                    {
                        if (args.isError == true)
                            Toast(args.error);
                        else
                            Toast(args.Count.ToString());
                    });
                    break;
                case "ResourceRemove":
                    this.Client.Resource.Remove(new Smobiler.Core.RPC.ClientResourceFilter("*c*", ""), (obj, args) =>
                    {
                        if (args.isError == true)
                            Toast(args.error);
                        else
                            Toast(args.Count.ToString());
                    });
                    break;
                case "GetNetWorkType":
                    this.Client.GetNetWorkType((obj, args) =>
                    {
                        if (args.isError == true)
                        {
                            MessageBox.Show(args.error);
                        }
                        else
                        {
                            MessageBox.Show(args.NetWorkType.ToString());
                        }
                    });
                    break;
                case "GetStatusbarHeight":
                    this.Client.GetStatusbarHeight((obj, args) =>
                    {
                        if (args.isError == true)
                        {
                            MessageBox.Show(args.error);
                        }
                        else
                        {
                            MessageBox.Show(args.Height.ToString());
                        }
                    });
                    break;
                case "PlayAudio":
                    this.Client.PlayAudio("001.mp3", AppDomain.CurrentDomain.BaseDirectory);
                    break;
                case "StopAudio":
                    this.Client.StopAudio();
                    break;
                case "SendEmail":
                    this.Client.SendEmail("标题", "文本", "admin@smobiler.com");
                    break;
                case "SendSMS":
                    this.Client.SendSMS("smobiler电话", "4000588560");
                    break;
                case "TelCall":
                    this.Client.TelCall("4000588560");
                    break;
                case "FileDownload":
                    this.Client.File.Download("领用单.doc", MobileResourceManager.DefaultDocumentResourceName, (obj, args) => { this.Toast(args.isError.ToString()); });
                    break;
                case "FileDelete":
                    this.Client.File.Delete("领用单.doc", MobileResourceManager.DefaultDocumentResourceName, (obj, args) => { this.Toast(args.isError.ToString()); });
                    break;
                case "FileOpen":
                    this.Client.File.Open("领用单.doc", MobileResourceManager.DefaultDocumentResourceName, (obj, args) => { this.Toast(args.isError.ToString()); });
                    break;
                case "FileList":
                    this.Client.File.List((obj, args) => { this.Toast(args.Count.ToString()); });
                    break;
                case "FileExists":
                    this.Client.File.Exists("领用单.doc", MobileResourceManager.DefaultDocumentResourceName, (obj, args) => { this.Toast(args.Exists.ToString()); });
                    break;
                case "FileUpload":
                    this.Client.File.Upload((obj, args) =>
                    {
                        if (args.isError == false)
                        {
                            args.SaveFile();
                            this.Toast(string.Format("{0}", args.ResourceID));
                        }
                        else
                        {
                            Toast(args.error);
                        }
                    });
                    break;
                case "UploadClientPath":
                    clientPath = "";
                    this.Client.File.UploadPath((obj, args) =>
                    {
                        if (args.isError == false)
                        {
                            clientPath = args.Resources.ElementAt(0).Value;
                            Toast(clientPath);
                        }
                        else
                        {
                            Toast(args.error);
                        }
                    });
                    break;
                case "UploadInitialPath":
                    if (string.IsNullOrEmpty(clientPath) == true)
                    {
                        MessageBox.Show("先点击上传本地文件路径");
                    }
                    else
                    {
                        this.Client.File.UploadPath(System.IO.Path.GetDirectoryName(clientPath).Replace("file:\\", "").Replace("\\", "/"), (obj, args) =>
                        {
                            if (args.isError == false)
                            {
                                this.Toast(string.Format("{0}", args.Resources.ElementAt(0).Value));
                            }
                            else
                            {
                                Toast(args.error);
                            }
                        });
                    }
                    break;
                case "OpenClientPath":
                    if (string.IsNullOrEmpty(clientPath) == false)
                        this.Client.File.OpenPath(clientPath, (obj, args) => { Toast(args.isError.ToString()); });
                    break;
                case "ClearCache":
                    this.Client.ClearCache((obj, args) =>
                    {
                        if (args.isError == false)
                            Toast("清除成功");
                        else
                            Toast(args.error);
                    });
                    break;
                case "GetClipboard":
                    this.Client.GetClipboard((obj, args) =>
                    {
                        if (args.isError == true)
                            Toast("isError: " + args.isError.ToString());
                        else
                            Toast(args.Data);
                    });
                    break;
                case "SetClipBoard":
                    this.Client.SetClipboard(DateTime.Now.ToString(), (obj, args) => { Toast("isError: " + args.isError.ToString()); });
                    break;
                case "OpenDataBase":
                    this.Client.SQLite.OpenOrCreate(new Smobiler.Core.RPC.SQLiteDataBase("oudi.db"), (obj, args) =>
                    {
                        if (args.isError == true)
                            MessageBox.Show(args.error);
                        else
                            Toast("OpenDataBase sucess");
                    });
                    break;
                case "SetDataBase":
                    this.Client.SQLite.Execute(new string[] { "create table IF NOT EXISTS tbloudi (ID INT PRIMARY KEY     NOT NULL,NAME           TEXT    NOT NULL )", "insert into tbloudi values(" + DateTime.Now.Millisecond + ",'oudi')" }, (obj, args) =>
                    {
                        if (args.isError == true)
                            MessageBox.Show(args.error);
                        else
                            Toast("SetDataBase sucess");
                    });
                    break;
                case "GetDataBase":
                    //select min(id) from tbloudi
                    //delete from tbloudi where id = 490
                    //select * from tbloudi
                    this.Client.SQLite.Read("select * from tbloudi", (obj, args) =>
                    {
                        if (args.isError == true)
                            MessageBox.Show(args.error);
                        else
                            Toast(args.Data.Rows.Count.ToString());
                    });
                    break;
                case "CloseDataBase":
                    this.Client.SQLite.Close(new Smobiler.Core.RPC.SQLiteDataBase("oudi.db"), (obj, args) =>
                    {
                        if (args.isError == true)
                            MessageBox.Show(args.error);
                        else
                            Toast("CloseDataBase sucess");
                    });
                    break;
                case "DeleteDataBase":
                    this.Client.SQLite.Delete(new Smobiler.Core.RPC.SQLiteDataBase("oudi.db"), (obj, args) =>
                    {
                        if (args.isError == true)
                            MessageBox.Show(args.error);
                        else
                            Toast("DeleteDataBase sucess");
                    });
                    break;
                case "ShowPermission":
                    this.Client.ShowPermission();
                    break;
                case "ShowOfflineResources":
                    this.Client.ShowOfflineResources();
                    break;
                case "ShowNetworkDiagnosis":
                    this.Client.ShowNetworkDiagnosis();
                    break;
                case "ShowAbout":
                    this.Client.ShowAbout();
                    break;
                case "IsOpenBlue":
                    try
                    {
                        this.Client.Bluetooth.IsOpen((object obj, Smobiler.Core.RPC.BluetoothManagerIsOpenArgs args) =>
                        {
                            if (args.IsOpen == true)
                                Toast("Open");
                            else
                                Toast("Not Open");
                        });
                    }
                    catch (Exception ex)
                    {
                        Toast(ex.Message, ToastLength.SHORT);
                    }
                    break;
                case "OpenBlue":
                    try
                    {
                        this.Client.Bluetooth.Show();
                    }
                    catch (Exception ex)
                    {
                        Toast(ex.Message, ToastLength.SHORT);
                    }
                    break;
                case "CoreVersion":
                    Toast(this.Form.Client.CoreVersion.ToString());
                    break;
                case "Device":
                    Toast(this.Form.Client.Device);
                    break;
                case "DeviceID":
                    Toast(this.Form.Client.DeviceID);
                    break;
                case "DeviceOS":
                    Toast(this.Form.Client.DeviceOS);
                    break;
                case "DeviceOSVersion":
                    Toast(this.Form.Client.DeviceOSVersion);
                    break;
                case "EnableStackView":
                    Toast(this.Form.Client.EnableStackView.ToString());
                    break;
                case "IPEndPoint":
                    Toast(this.Form.Client.IPEndPoint.ToString());
                    break;
                case "LastDate":
                    Toast(this.Form.Client.LastDate.ToString());
                    break;
                case "ScreenDensity":
                    Toast(this.Form.Client.ScreenDensity.ToString());
                    break;
                case "ScreenSize":
                    Toast(this.Form.Client.ScreenSize.ToString());
                    break;
                case "SessionID":
                    Toast(this.Form.Client.SessionID);
                    break;
                case "StartDate":
                    Toast(this.Form.Client.StartDate.ToString());
                    break;
                case "UserSessionID":
                    Toast(this.Form.Client.UserSessionID);
                    break;
                case "Version":
                    Toast(this.Form.Client.Version.ToString());
                    break;
                case "Exit":
                    this.Form.Client.Exit();
                    break;
                case "ExitAndQuit":
                    this.Form.Client.ExitAndQuit();
                    break;
            }
            }
    }
}