# Paylink

## 简介

Paylink 是基于 .NET Core 、 ASP.NET Core 开发的支付SDK集，它极大简化了API调用及通知的处理流程。

[![Build status](https://github.com/essensoft/paylink/workflows/.NET/badge.svg?branch=dev)](https://github.com/essensoft/paylink/actions?query=branch%3Adev)

## NuGet 包

Package  | NuGet | Downloads
-------- | :---- | :-------- 
Essensoft.Paylink.Alipay | [![NuGet](https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay?style=flat-square)](https://www.nuget.org/packages/Essensoft.Paylink.Alipay) | [![Downloads](https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay?style=flat-square)](https://www.nuget.org/packages/Essensoft.Paylink.Alipay)
Essensoft.Paylink.WeChatPay | [![NuGet](https://img.shields.io/nuget/v/Essensoft.Paylink.WeChatPay?style=flat-square)](https://www.nuget.org/packages/Essensoft.Paylink.WeChatPay) | [![Downloads](https://img.shields.io/nuget/dt/Essensoft.Paylink.WeChatPay?style=flat-square)](https://www.nuget.org/packages/Essensoft.Paylink.WeChatPay)
Essensoft.Paylink.Security | [![NuGet](https://img.shields.io/nuget/v/Essensoft.Paylink.Security?style=flat-square)](https://www.nuget.org/packages/Essensoft.Paylink.Security) | [![Downloads](https://img.shields.io/nuget/dt/Essensoft.Paylink.Security?style=flat-square)](https://www.nuget.org/packages/Essensoft.Paylink.Security)
Essensoft.AspNetCore.Payment.Alipay | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.Alipay?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Alipay) | [![Downloads](https://img.shields.io/nuget/dt/Essensoft.AspNetCore.Payment.Alipay?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Alipay)
Essensoft.AspNetCore.Payment.WeChatPay | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.WeChatPay?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.WeChatPay) | [![Downloads](https://img.shields.io/nuget/dt/Essensoft.AspNetCore.Payment.WeChatPay?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.WeChatPay)
Essensoft.AspNetCore.Payment.Security | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.Security?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Security) | [![Downloads](https://img.shields.io/nuget/dt/Essensoft.AspNetCore.Payment.Security?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Security)

## QQ群

- [Paylink 交流①群: 522457525](https://shang.qq.com/wpa/qunwpa?idkey=aac56c8f02f54893267d3ac90787c1794a7687f3c31a923812a36b67c4ee6271)
- [Paylink 交流②群: 204076462](https://shang.qq.com/wpa/qunwpa?idkey=a77c990f2a8fca61f7eaf87ad34eae1a4ac4ebb98968a2602514dfba0c23c108)
- [Paylink 交流③群: 755039581](https://shang.qq.com/wpa/qunwpa?idkey=ef1dcf99efe9fe2cbb596ec743daa748f9296c1206bd19c64090ffe35a5e0ff9)

## 支持渠道

1. 支付宝 [文档中心](https://openhome.alipay.com/docCenter/docCenter.htm)

* 同步 [alipay-sdk-net-all](https://github.com/alipay/alipay-sdk-net-all) 所有API.

2. 微信支付

* V2版 [开发文档](https://pay.weixin.qq.com/wiki/doc/api/index.html)
    - 付款码支付(刷卡)
    - JSAPI支付(公众号)
    - Native支付(扫码)
    - APP支付
    - H5支付
    - 小程序支付
    - 刷脸支付
    - 现金红包
    - 企业付款(零钱/银行卡)
    - 分账
    - 酒店押金
    - 委托扣款
    - ..

* V3版 [开发者文档](https://pay.weixin.qq.com/wiki/doc/apiv3/index.shtml)
    - 基础支付
    - 基础支付（服务商）
    - 商户进件（服务商）
    - 微信支付分

## 开发环境
* Windows 10
* VS 2019 16.8.x
* .NET 5.0

## 使用方式

* [示例项目](samples/WebApplicationSample)

## 致谢

[Varorbc](https://github.com/Varorbc)
[Alipay](https://github.com/alipay)

## 捐赠

[捐赠名单](FUNDING.md)

---

![QrCode](qrcode.png)

## 项目地址

- [GitHub](https://github.com/essensoft/paylink)
- [Gitee](https://gitee.com/essensoft/paylink)

## 许可协议

[MIT](LICENSE.md).
