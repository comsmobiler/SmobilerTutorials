## Smobiler Tutorials
* SmobilerTutorials.sln 对应4.8版本
* 也可前往Gitee码云获取源码，https://gitee.com/smobiler/SmobilerTutorials
### 快速入门 - 环境搭建

##### 服务端
* 操作系统：Windows XP SP2及以上版本
* 开发环境：.NET Framework 4.0及以上版本
* 开发工具：Visual Studio 2010及以上版本
* 打开电脑上的浏览器，访问 https://www.smobiler.com/download.html ，并选择Designer，下载并安装。

##### 客户端
* Android 4.4 及以上版本
	* 打开Android手机上的任意浏览器，访问 https://www.smobiler.com ，点击Smobiler进行下载，下载完成后点击安装
* IOS 9.0 以上版本
	* 打开IOS上的**safari**浏览器，访问 https://www.smobiler.com ，点击Smobiler进行下载
	* 安装完成后，需要在苹果手机上信任开发证书，详见：https://www.smobiler.com/forum.php?mod=viewthread&tid=10

### 开发第一个示例应用
* 可参考：
	* https://www.smobiler.com/guide/quickstart.aspx
	* https://www.cnblogs.com/oudi/p/8288617.html

### 控件介绍

#### Smobiler继承结构
* MobileControl【控件，有UI，可展示】
	* MobileBindableControl【所有可做数据绑定的控件***基类***】
		* Button、Label、TextBox、Image...
	* SegmentedControl、WebView、MapTagView、Line...
	* MobileNativeControl【插件***基类***】
		* PDFView、ProgressView、MapView...
	* MobileLayoutControl【布局控件***基类***】
		* ListView、GridView、ListMenuView...
		* MobileContainerControl【容器控件***基类***】
			* Panel、SwipeView、TabPageView...
			* MobileParentControl【父控件***基类***】
				* MobileForm【窗体】
				* MobileUserControl【用户控件】
			* MobileNativeContainerControl【插件容器控件***基类***】
				* PercentageCircle
* MobileComponent【组件，没有UI，功能性】
	* Camera、GPS...
	* WeiXin、AliPay、FingerPrint...

---

#### [MobileControl](Document/Components/MobileControl.MD)

#### 基础控件
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [Button](Document/Components/Button.MD) | 按钮控件 | [Label](Document/Components/Label.MD) | 文本控件 |
| [TextBox](Document/Components/TextBox.MD) | 输入框控件 | [CheckBox](Document/Components/CheckBox.MD) | 单选控件 |
| [Swith](Document/Components/Swith.MD) | 开关控件 | [Image](Document/Components/Image.MD) | 图像控件 |
| [FontIcon](Document/Components/FontIcon.MD) | 图标控件 | [ZoomImage](Document/Components/ZoomImage.MD) | 缩放图像控件 |
| [Line](Document/Components/Line.MD) | 线条控件 | [Slider](Document/Components/Slider.MD) | 滚动条控件 |
| [DatePicker](Document/Components/DatePicker.MD) | 日期选择控件 | [Calendar](Document/Components/Calendar.MD) | 日历控件 |
| [Picker](Document/Components/Picker.MD) | 元素选择控件 | [Progress](Document/Components/Progress.MD) | 进度条控件 |
| [Spinner](Document/Components/Spinner.MD) | 下拉列表控件 | [SegmentedControl](Document/Components/SegmentedControl.MD) | 单元控件 |
| [WebView](Document/Components/WebView.MD) | 浏览器控件 | [MapTagView](Document/Components/MapTagView.MD) | 地理位置标签控件 |
| [BarcodeView](Document/Components/BarcodeView.MD) | 条码控件 |  |  |

#### MobileContainerControl 容器控件
* Panel
	* TouchablePanel
	* ScrollablePanel
* TabPageView
* SwipeView

#### MobileParentControl 父控件
* [MobileForm](Document/Components/MobileForm.MD)
* [MobileUserControl](Document/Components/MobileUserControl.MD)

#### [MobileLayoutControl](Document/Components/MobileLayoutControl.MD) 模板控件
* ListView
* GridView
* PageView

#### MobileComponent 组件
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [Camera](Document/Components/Camera.MD) | 相机组件 | [BarCodeScanner](Document/Components/BarCodeScanner.MD) | 条码扫描组件 |
| [VoiceRecorder](Document/Components/VoiceRecorder.MD) | 录音组件 | [GPS](Document/Components/GPS.MD) | 定位组件 |
| [Timer](Document/Components/Timer.MD) | 计时器组件 |  |  |

#### 图表控件 Chart
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [LineChart](Document/Components/LineChart.MD) | 线状图表 | [BarChart](Document/Components/BarChart.MD) | 柱状图表 |
| [PieChart](Document/Components/PieChart.MD) | 饼状图表 | [BubbleChart](Document/Components/BubbleChart.MD) | 气泡图表 |
| [RadarChart](Document/Components/RadarChart.MD) | 雷达图 | [ScatterChart](Document/Components/ScatterChart.MD) | 散点图 |
| [CandleStickChart](Document/Components/CandleStickChart.MD) | K线图 |  |  |

#### Client

---

### Controls
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [AlbumView](Document/Controls/AlbumView.MD) | 相册控件 | [IconMenuView](Document/Controls/IconMenuView.MD) | 图标菜单控件 |
| [ImageButton](Document/Controls/ImageButton.MD) | 图片按钮 | [ImageEx](Document/Controls/ImageEx.MD) | 扩展图像控件 |
| [ListMenuView](Document/Controls/ListMenuView.MD) | 列表菜单控件 | [NodeView](Document/Controls/NodeView.MD) | 节点控件 |
| [Numeric](Document/Controls/Numeric.MD) | 数量控件 | [PopList](Document/Controls/PopList.MD) | 列表选择控件 |
| [RadioGroup](Document/Controls/RadioGroup.MD) | 选项按钮组控件 | [RatingBar](Document/Controls/RatingBar.MD) | 评价控件 |
| [TableView](Document/Controls/TableView.MD) | 表格控件 | [Title](Document/Controls/Title.MD) | 标题栏控件 |
| [ToolBar](Document/Controls/ToolBar.MD) | 工具栏 | [TreeView](Document/Controls/TreeView.MD) | 树形菜单控件 |

---

### Plugins
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [AliPay](Document/Plugins/AliPay.MD) | 相册控件 | [AutoCompleteTextBox](Document/Plugins/AutoCompleteTextBox.MD) | 图标菜单控件 |
| [CalenderStrip](Document/Plugins/CalenderStrip.MD) | 图片按钮 | [DropdownAert](Document/Plugins/DropdownAert.MD) | 扩展图像控件 |
| [FingerPrint](Document/Plugins/FingerPrint.MD) | 列表菜单控件 | [HighLightLabel](Document/Plugins/HighLightLabel.MD) | 节点控件 |
| [IM](Document/Plugins/IM.MD) | 数量控件 | [LiveStreamPlayer](Document/Plugins/LiveStreamPlayer.MD) | 列表选择控件 |
| [MapRoute](Document/Plugins/MapRoute.MD) | 选项按钮组控件 | [MapTrimView](Document/Plugins/MapTrimView.MD) | 评价控件 |
| [MapView](Document/Plugins/MapView.MD) | 表格控件 | [MarqueeLabel](Document/Plugins/MarqueeLabel.MD) | 标题栏控件 |
| [MediaView](Document/Plugins/MediaView.MD) | 工具栏 | [PDFView](Document/Plugins/PDFView.MD) | 树形菜单控件 |
| [PercentageCircle](Document/Plugins/PercentageCircle.MD) | 工具栏 | [ProgressView](Document/Plugins/ProgressView.MD) | 树形菜单控件 |
| [PulseLoader](Document/Plugins/PulseLoader.MD) | 工具栏 | [SignatureView](Document/Plugins/SignatureView.MD) | 树形菜单控件 |
| [SwitchSelector](Document/Plugins/SwitchSelector.MD) | 工具栏 | [TextBoxField](Document/Plugins/TextBoxField.MD) | 树形菜单控件 |
| [WeiXin](Document/Plugins/WeiXin.MD) | 工具栏 |  |  |

---

### Devices
