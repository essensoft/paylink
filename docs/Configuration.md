# 关于Payment中 参数设置 介绍

## 以WeChatPay为例，有以下3种方式：

1. 引入WeChatPay同时设置参数(内置选项配置)
```
services.AddWeChatPay(opt => { opt.AppId = "xx"; opt.MchId = "xx"; opt.Key = "xx"; });
```

2. 使用配置文件的方式设置参数(选项配置) [微软官方教程](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/configuration/options?view=aspnetcore-2.1)

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

* 配置选项
```
services.Configure<WeChatPayOptions>(Configuration.GetSection("WeChatPay"));
```

3. 多商户模式配置

* 设置配置文件 appsettings.json
```
{
  "WeChatPay1": {
    "AppId": "xxx",
    "MchId": "xxx",
    "Key": "xxx",
    "Certificate": "xxx"
  },
  "WeChatPay2": {
  "AppId": "xxx",
  "MchId": "xxx",
  "Key": "xxx",
  "Certificate": "xxx"
  },
}
```

* 配置多个商户选项

```
// WeChatPay1 / WeChatPay2 为选项名称 可自定义 调用的时候需要用到。
services.Configure<WeChatPayOptions>("WeChatPay1",Configuration.GetSection("WeChatPay1"));
services.Configure<WeChatPayOptions>("WeChatPay2",Configuration.GetSection("WeChatPay2"));
```

* 调用指定商户配置选项(根据选项名称)
```
await _client.ExecuteAsync(request, "WeChatPay1");
```

注:具体配置选项参数可查看对应Options，例如 WeChatPayOptions、AlipayOptions、...
