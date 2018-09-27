### Speech
> 语音识别插件

#### 属性
| 名称 | 说明 |
|:---|:---|
| IsRealTime | 是否实时返回语音结果 |
| TrainingServer | 语音学习服务器地址 |

#### 方法
| 名称 | 说明 |
|:---|:---|
| Init | 初始化语音引擎 |
| RecognizeStart | 开始识别语音 |
| RecognizePause | 暂停识别语音 |
| RecognizeStop | 停止识别语音 |
| UploadTrainingSample | 上传语音样本 |
| DownloadTrainingParams | 下载语音识别参数 |

#### 事件
| 名称 | 说明 |
|:---|:---|
| Recognized | 在语音识别时发生 |