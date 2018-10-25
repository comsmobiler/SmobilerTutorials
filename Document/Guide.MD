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

#### [MobileControl](Components/MobileControl.MD)

#### 基础控件
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [Button](Components/Button.MD) | 按钮控件 | [Label](Components/Label.MD) | 文本控件 |
| [TextBox](Components/TextBox.MD) | 输入框控件 | [CheckBox](Components/CheckBox.MD) | 单选控件 |
| [Swith](Components/Swith.MD) | 开关控件 | [Image](Components/Image.MD) | 图像控件 |
| [FontIcon](Components/FontIcon.MD) | 图标控件 | [ZoomImage](Components/ZoomImage.MD) | 缩放图像控件 |
| [Line](Components/Line.MD) | 线条控件 | [Slider](Components/Slider.MD) | 滚动条控件 |
| [DatePicker](Components/DatePicker.MD) | 日期选择控件 | [Calendar](Components/Calendar.MD) | 日历控件 |
| [Picker](Components/Picker.MD) | 元素选择控件 | [Progress](Components/Progress.MD) | 进度条控件 |
| [Spinner](Components/Spinner.MD) | 下拉列表控件 | [SegmentedControl](Components/SegmentedControl.MD) | 单元控件 |
| [WebView](Components/WebView.MD) | 浏览器控件 | [MapTagView](Components/MapTagView.MD) | 地理位置标签控件 |
| [BarcodeView](Components/BarcodeView.MD) | 条码控件 |  |  |

#### MobileContainerControl 容器控件
* Panel
	* TouchablePanel
	* ScrollablePanel
* TabPageView
* SwipeView

#### MobileParentControl 父控件
* [MobileForm](Components/MobileForm.MD)
* [MobileUserControl](Components/MobileUserControl.MD)

#### [MobileLayoutControl](Components/MobileLayoutControl.MD) 模板控件
* ListView
* GridView
* PageView

#### MobileComponent 组件
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [Camera](Components/Camera.MD) | 相机组件 | [BarCodeScanner](Components/BarCodeScanner.MD) | 条码扫描组件 |
| [VoiceRecorder](Components/VoiceRecorder.MD) | 录音组件 | [GPS](Components/GPS.MD) | 定位组件 |
| [Timer](Components/Timer.MD) | 计时器组件 |  |  |

#### 图表控件 Chart
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [LineChart](Components/LineChart.MD) | 线状图表 | [BarChart](Components/BarChart.MD) | 柱状图表 |
| [PieChart](Components/PieChart.MD) | 饼状图表 | [BubbleChart](Components/BubbleChart.MD) | 气泡图表 |
| [RadarChart](Components/RadarChart.MD) | 雷达图 | [ScatterChart](Components/ScatterChart.MD) | 散点图 |
| [CandleStickChart](Components/CandleStickChart.MD) | K线图 |  |  |

#### Client

---

### Controls
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [AlbumView](Controls/AlbumView.MD) | 相册控件 | [IconMenuView](Controls/IconMenuView.MD) | 图标菜单控件 |
| [ImageButton](Controls/ImageButton.MD) | 图片按钮 | [ImageEx](Controls/ImageEx.MD) | 扩展图像控件 |
| [ListMenuView](Controls/ListMenuView.MD) | 列表菜单控件 | [NodeView](Controls/NodeView.MD) | 节点控件 |
| [Numeric](Controls/Numeric.MD) | 数量控件 | [PopList](Controls/PopList.MD) | 列表选择控件 |
| [RadioGroup](Controls/RadioGroup.MD) | 选项按钮组控件 | [RatingBar](Controls/RatingBar.MD) | 评价控件 |
| [TableView](Controls/TableView.MD) | 表格控件 | [Title](Controls/Title.MD) | 标题栏控件 |
| [ToolBar](Controls/ToolBar.MD) | 工具栏 | [TreeView](Controls/TreeView.MD) | 树形菜单控件 |

---

### Plugins
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [AliPay](Plugins/AliPay.MD) | 相册控件 | [AutoCompleteTextBox](Plugins/AutoCompleteTextBox.MD) | 图标菜单控件 |
| [CalenderStrip](Plugins/CalenderStrip.MD) | 图片按钮 | [DropdownAert](Plugins/DropdownAert.MD) | 扩展图像控件 |
| [FingerPrint](Plugins/FingerPrint.MD) | 列表菜单控件 | [HighLightLabel](Plugins/HighLightLabel.MD) | 节点控件 |
| [IM](Plugins/IM.MD) | 数量控件 | [LiveStreamPlayer](Plugins/LiveStreamPlayer.MD) | 列表选择控件 |
| [MapRoute](Plugins/MapRoute.MD) | 选项按钮组控件 | [MapTrimView](Plugins/MapTrimView.MD) | 评价控件 |
| [MapView](Plugins/MapView.MD) | 表格控件 | [MarqueeLabel](Plugins/MarqueeLabel.MD) | 标题栏控件 |
| [MediaView](Plugins/MediaView.MD) | 工具栏 | [PDFView](Plugins/PDFView.MD) | 树形菜单控件 |
| [PercentageCircle](Plugins/PercentageCircle.MD) | 工具栏 | [ProgressView](Plugins/ProgressView.MD) | 树形菜单控件 |
| [PulseLoader](Plugins/PulseLoader.MD) | 工具栏 | [SignatureView](Plugins/SignatureView.MD) | 树形菜单控件 |
| [SwitchSelector](Plugins/SwitchSelector.MD) | 工具栏 | [TextBoxField](Plugins/TextBoxField.MD) | 树形菜单控件 |
| [WeiXin](Plugins/WeiXin.MD) | 工具栏 |  |  |

---

### Devices
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [R100](Devices/R100.MD) | Smobiler条码扫描枪 | [R200](Devices/R200.MD) | Smobiler条码带键盘扫描枪 |
| [R1000](Devices/R1000.MD) | Smobiler近距离RFID扫描枪 | [R2000](Devices/R2000.MD) | Smobiler远距离RFID扫描枪 |
| [TC25](Devices/TC25.MD) | 斑马条码扫描枪 | [V7000](Devices/V7000.MD) | Smobiler条码扫描枪 |
| [P370](Devices/P370.MD) | SmobilerPOS打印机 | [ZR338](Devices/ZR338.MD) | 斑马打印机 |

---

### Samples

---

### AI
| 名称 | 说明 | 名称 | 说明 |
|:---|:---|:---|:---|
| [Plate](AI/Plate.MD) | 车牌识别插件 | [Speech](AI/Speech.MD) | 语音识别插件 |