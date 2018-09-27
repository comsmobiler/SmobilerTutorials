### Camera
> 按钮

#### 属性
| 名称 | 说明 |
|:---|:---|
| TimeOut | 说明 |
| Mode | 说明 |
| CompressedResolution | 说明 |
| CompressedQuality | 说明 |
| QualityMode | 说明 |
| VideoCompressedQuality | 说明 |
| VideoDuration | 视频拍摄时长（秒） |
| ContinuousNumber | 连续拍照的最大张数 |
| AlbumCount | 在CameraMode为Alubum时，上传的数量 |
| AllowEdit | 是否允许编辑图片 |

* CameraMode 用于选择相机模式
	* Camera
	* CameraAndAlbum
	* AlbumSingle
	* Album
	* CameraContinuous
	* CameraVideo
	* AlbumVideo

#### 方法
| 名称 | 说明 |
|:---|:---|
| GetPhoto | 说明 |
| GetClientPhotoPath | 说明 |
| GetPhotoOffline |  |

#### 事件
| 名称 | 说明 |
|:---|:---|
| ImageCaptured | 说明 |
| ClientImageCaptured | 说明 |
| OfflineImageCaptured |  |

#### 示例代码