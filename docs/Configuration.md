# 关于Payment中 参数配置 介绍

* 以WeChatPay为例，有以下2种方式：

1. 引入WeChatPay同时配置参数
```
services.AddWeChatPay(opt => { opt.AppId = "xx"; opt.MchId = "xx"; opt.Key = "xx"; });
services.AddWeChatPayHttpClient();
```

2. 引入WeChatPay
```
services.AddWeChatPay();
services.AddWeChatPayHttpClient();
```
* 使用配置文件配置参数 [微软官方教程](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/configuration/options?view=aspnetcore-2.1)
```
services.Configure<WeChatPayOptions>(Configuration.GetSection("WeChatPay"));
```
* 设置配置文件 appsettings.json
```
{
  "WeChatPay": {
    "AppId": "xxx",
    "MchId": "xxx",
    "Key": "xxx",
    "Certificate": "xxx"
  },
}
```
注:配置参数可查看 XXXXOptions，例如 WeChatPayOptions、AlipayOptions