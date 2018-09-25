# 关于Payment中使用 HttpClient 配置介绍

* 以WeChatPay为例，有以下几种方式：

1. 添加默认HttpClient供WeChatPayClient使用. (未使用到API证书时适用)
```
services.AddWeChatPayHttpClient();
```

2. 添加默认HttpClient和证书HttpClient供WeChatPayClient使用 (目前仅WeChatPay\QPay部分API有使用到API证书配置) 

* 根据证书路径
```
services.AddWeChatPayHttpClient();
services.AddWeChatPayCertificateHttpClient(new X509Certificate2(Configuration["WeChatPay:Certificate"], Configuration["WeChatPay:MchId"], X509KeyStorageFlags.MachineKeySet));
//services.AddWeChatPayCertificateHttpClient("certificateName1", new X509Certificate2(Configuration["WeChatPay:Certificate"], Configuration["WeChatPay:MchId"], X509KeyStorageFlags.MachineKeySet));
//若配置证书名为"certificateName1", 则执行请求时需要配置证书名(该API请求需要证书的情况下), 如: await _client.ExecuteAsync(request, "certificateName1");
```

* 根据证书Base64String
```
services.AddWeChatPayHttpClient();
services.AddWeChatPayCertificateHttpClient(new X509Certificate2(Convert.FromBase64String(Configuration["WeChatPay:Certificate"]), Configuration["WeChatPay:MchId"], X509KeyStorageFlags.MachineKeySet));
//services.AddWeChatPayCertificateHttpClient("certificateName1", new X509Certificate2(Convert.FromBase64String(Configuration["WeChatPay:Certificate"]), Configuration["WeChatPay:MchId"], X509KeyStorageFlags.MachineKeySet));
//若配置证书名为"certificateName1", 则执行请求时需要配置证书名(该API请求需要证书的情况下), 如: await _client.ExecuteAsync(request, "certificateName1");
```

3.  自行配置HttpClient供WeChatPayClient使用 (目前仅WeChatPay\QPay部分API有使用到API证书配置) 
```
services.AddHttpClient(WeChatPayOptions.DefaultClientName);
services.AddHttpClient(WeChatPayOptions.CertificateClientName + "." + "Default").ConfigurePrimaryHttpMessageHandler(() => { ... });
// "Default" 为默认执行请求的API证书名, 可自行配置.
```