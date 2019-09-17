using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Plugins;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoAndroidCodeCompiler : Smobiler.Core.Controls.MobileForm
    {
        public demoAndroidCodeCompiler() : base()
        {
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            //安卓震动功能,可先网上搜索头文件与代码
            AndroidCodeProvider provider = new AndroidCodeProvider();
            provider.Imports.Add("android.os.Vibrator");
            provider.MethodBody = @"
                Vibrator vib = (Vibrator) activity.getSystemService(Service.VIBRATOR_SERVICE);
                vib.vibrate(200);
                resultValue=""success"";";
            //Run方法中provider参数填写代码，value参数对应provider参数中用户自行添加的变量value
            this.androidCodeCompiler1.Run(provider, (obj, args) =>
            {
                if (args.isError == true)
                    MessageBox.Show(args.error);
                else
                    Toast("Sucess");
            });
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Press(object sender, EventArgs e)
        {

            AndroidCodeProvider provider = new AndroidCodeProvider();
            provider.Imports.Add("android.content.Intent;");
            provider.Imports.Add("android.content.ComponentName;");
            provider.MethodBody = @"    
            Intent intent = new Intent(Intent.ACTION_MAIN);
            ComponentName cmp = new ComponentName(""com.tencent.mm"",""com.tencent.mm.ui.LauncherUI"");
            intent.addCategory(Intent.CATEGORY_LAUNCHER);
            intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            intent.setComponent(cmp);
            activity.startActivity(intent); ";
            this.androidCodeCompiler1.Run(provider, (obj, args) =>
            {
                if (args.isError == true)
                    MessageBox.Show(args.error);
                else
                    Toast("success");
            });
        }

        private void btngetOcrRegister_Press(object sender, EventArgs e)
        {
            AndroidCodeProvider provider = new AndroidCodeProvider();
            provider.Imports.Add("com.baidu.ocr.sdk.OCR");
            provider.Imports.Add("com.baidu.ocr.sdk.OnResultListener");
            provider.Imports.Add("com.baidu.ocr.sdk.exception.OCRError");
            provider.Imports.Add("com.baidu.ocr.sdk.model.AccessToken");
            provider.Imports.Add("com.baidu.ocr.sdk.model.GeneralBasicParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.GeneralParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.GeneralResult");
            provider.Imports.Add("com.baidu.ocr.sdk.model.OcrRequestParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.OcrResponseResult");
            provider.Imports.Add("com.baidu.ocr.sdk.model.IDCardParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.IDCardResult");
            provider.Imports.Add("java.util.Timer");
            provider.Imports.Add("java.util.TimerTask");
            provider.Imports.Add("java.io.File");
            provider.Imports.Add("com.baidu.ocr.ui.camera.CameraActivity");
            provider.MethodBody = @"OCR.getInstance(context).initAccessTokenWithAkSk(new OnResultListener<AccessToken>() {
        @Override 
        public void onResult(AccessToken result) { 
            String token = result.getAccessToken(); 
            callback(""{success: true,tocken:"" + token +""}"");
        }
        @Override
        public void onError(OCRError error)
        {
            callback(""{success:false,errcode:"" + error.getErrorCode() + ""}"");
        }
    }, activity.getApplicationContext(), ""百度OCR API Key"", ""百度OCR Secret Key"");";
            //上面代码中百度OCR API Key与Secret Key需要https://cloud.baidu.com注册申请
            this.androidCodeCompiler1.Run(provider, (obj, args) =>
            {
                if (args.isError == true)
                    MessageBox.Show(args.error);
                else
                    Toast("Sucess");
            });
        }

        private void btngetOcrParams_Press(object sender, EventArgs e)
        {
            AndroidCodeProvider provider = new AndroidCodeProvider();
            provider.Imports.Add("com.baidu.ocr.sdk.OCR");
            provider.Imports.Add("com.baidu.ocr.sdk.OnResultListener");
            provider.Imports.Add("com.baidu.ocr.sdk.exception.OCRError");
            provider.Imports.Add("com.baidu.ocr.sdk.model.AccessToken");
            provider.Imports.Add("com.baidu.ocr.sdk.model.GeneralBasicParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.GeneralParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.GeneralResult");
            provider.Imports.Add("com.baidu.ocr.sdk.model.OcrRequestParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.OcrResponseResult");
            provider.Imports.Add("com.baidu.ocr.sdk.model.IDCardParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.IDCardResult");
            provider.Imports.Add("java.io.File");
            provider.Imports.Add("com.baidu.ocr.ui.camera.CameraActivity");
            provider.MethodBody = @"Intent intent = new Intent(activity, CameraActivity.class);
    intent.putExtra(CameraActivity.KEY_OUTPUT_FILE_PATH,new File(activity.getFilesDir(),""pic.jpg"").getAbsolutePath());intent.putExtra(CameraActivity.KEY_CONTENT_TYPE, CameraActivity.CONTENT_TYPE_GENERAL);activity.startActivityForResult(intent, 456);";
            provider.MethodResult = @"String contentType = data.getStringExtra(CameraActivity.KEY_CONTENT_TYPE);
    File filePath = new File(activity.getFilesDir(),""pic.jpg"");
    if (requestCode == 456)
            {
                if (resultCode == Activity.RESULT_OK && filePath.exists() == true)
                {
                   // 通用文字识别参数设置
    GeneralBasicParams param = new GeneralBasicParams();
    param.setDetectDirection(true);
    param.setImageFile(new File(activity.getFilesDir(),""pic.jpg""));

    // 调用通用文字识别服务
            OCR.getInstance(activity.getApplication().getApplicationContext()).recognizeGeneralBasic(param, new OnResultListener<GeneralResult>() {
        @Override
        public void onResult(GeneralResult result) {
            // 调用成功，返回GeneralResult对象
            callback(""{success: true,result:"" + result.getJsonRes() + ""}"");
        }
        @Override
        public void onError(OCRError error)
        {
            // 调用失败，返回OCRError对象
            callback(""{success:false,errcode:"" + error.getErrorCode() + ""}"");
        }
    });
                }
                else
                {
                   callback(""{\""success\"":false,\""error\"":\""未获取到返回内容\""}"");
                }
            }
            ";
            this.androidCodeCompiler1.Run(provider, (obj, args) =>
            {
                if (args.isError == true)
                    MessageBox.Show(args.error);
                else
                    Toast("Sucess");
            });
        }

        private void btnIDCardParams_Press(object sender, EventArgs e)
        {
            AndroidCodeProvider provider = new AndroidCodeProvider();
            provider.Imports.Add("com.baidu.ocr.sdk.OCR");
            provider.Imports.Add("com.baidu.ocr.sdk.OnResultListener");
            provider.Imports.Add("com.baidu.ocr.sdk.exception.OCRError");
            provider.Imports.Add("com.baidu.ocr.sdk.model.AccessToken");
            provider.Imports.Add("com.baidu.ocr.sdk.model.GeneralBasicParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.GeneralParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.GeneralResult");
            provider.Imports.Add("com.baidu.ocr.sdk.model.OcrRequestParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.OcrResponseResult");
            provider.Imports.Add("com.baidu.ocr.sdk.model.IDCardParams");
            provider.Imports.Add("com.baidu.ocr.sdk.model.IDCardResult");
            provider.Imports.Add("java.io.File");
            provider.Imports.Add("com.baidu.ocr.ui.camera.CameraActivity");
            provider.MethodBody = @"Intent intent = new Intent(activity, CameraActivity.class);
    intent.putExtra(CameraActivity.KEY_OUTPUT_FILE_PATH,new File(activity.getFilesDir(),""pic.jpg"").getAbsolutePath());intent.putExtra(CameraActivity.KEY_CONTENT_TYPE, CameraActivity.CONTENT_TYPE_GENERAL);activity.startActivityForResult(intent, 456);";
            provider.MethodResult = @"String contentType = data.getStringExtra(CameraActivity.KEY_CONTENT_TYPE);
    File filePath = new File(activity.getFilesDir(),""pic.jpg"");
    if (requestCode == 456)
            {
                if (resultCode == Activity.RESULT_OK && filePath.exists() == true)
                {
                   // 身份证识别参数设置
    IDCardParams param = new IDCardParams();
    param.setImageFile(new File(activity.getFilesDir(),""pic.jpg""));
    // 调用身份证识别服务
    OCR.getInstance(activity.getApplication().getApplicationContext()).recognizeIDCard(param, new OnResultListener<IDCardResult>() {
    @Override
    public void onResult(IDCardResult result) {
        // 调用成功，返回IDCardResult对象
        callback(""{ success: true,result: "" + result.getJsonRes() + ""}"");
    }
        @Override
    public void onError(OCRError error)
        {
            // 调用失败，返回OCRError对象
            callback(""{success:false,errcode:"" + error.getErrorCode() + ""}"");
        }
    });
                }
                else
                {
                    callback(""{\""success\"":false,\""error\"":\""未获取到返回内容\""}"");
                }
            }
            ";
            this.androidCodeCompiler1.Run(provider, (obj, args) =>
            {
                if (args.isError == true)
                    MessageBox.Show(args.error);
                else
                    Toast("Sucess");
            });
        }

        private void androidCodeCompiler1_AndroidCodeCompilerResult(object sender, AndroidCodeCompilerEventArgs e)
        {
            Toast(e.Data);
        }
    }
}