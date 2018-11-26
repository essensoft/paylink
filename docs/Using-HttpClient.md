# 关于Payment中使用 HttpClient 配置介绍

## Payment使用HttpClient提交API请求，务必在项目中引入它。

## 引入 HttpClient

```
services.AddHttpClient();
```

## API证书配置(仅QPay 与 WeChatPay的部分API 使用到API证书。)

* API证书配置

```
// 证书名称可自定义
services.AddHttpClient("证书名称").ConfigurePrimaryHttpMessageHandler(() =>
{
    // 载入证书
    var certificate = new X509Certificate2("", "", X509KeyStorageFlags.MachineKeySet);
    var handler = new HttpClientHandler();
    handler.ClientCertificates.Add(certificate);
    return handler;
});
```

* API证书使用

```
var request = new WeChatPayRefundRequest()
{
...
};
var response = await _client.ExecuteAsync(request, "证书名称");
```
