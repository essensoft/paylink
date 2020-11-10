# Payment

## 简介

Payment 是基于 .NET Core / ASP.NET Core 开发，支持多商户的跨平台支付SDK集。
简化了API调用及相关通知的处理流程。

[![Build status](https://dev.azure.com/essensoft/payment/_apis/build/status/payment-Dev-CI)](https://dev.azure.com/essensoft/payment/_build/latest?definitionId=18)

## Package

Package  | NuGet | Downloads
-------- | :---- | :-------- 
Essensoft.AspNetCore.Payment.Alipay | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.Alipay?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Alipay) | [![Downloads](https://img.shields.io/nuget/dt/Essensoft.AspNetCore.Payment.Alipay?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Alipay)
Essensoft.AspNetCore.Payment.WeChatPay | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.WeChatPay?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.WeChatPay) | [![Downloads](https://img.shields.io/nuget/dt/Essensoft.AspNetCore.Payment.WeChatPay?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.WeChatPay)
Essensoft.AspNetCore.Payment.Security | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.Security?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Security) | [![Downloads](https://img.shields.io/nuget/dt/Essensoft.AspNetCore.Payment.Security?style=flat-square)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Security)

## QQ群

- [Payment 交流①群: 522457525](https://shang.qq.com/wpa/qunwpa?idkey=aac56c8f02f54893267d3ac90787c1794a7687f3c31a923812a36b67c4ee6271)
- [Payment 交流②群: 204076462](https://shang.qq.com/wpa/qunwpa?idkey=a77c990f2a8fca61f7eaf87ad34eae1a4ac4ebb98968a2602514dfba0c23c108)
- [Payment 交流③群: 755039581](https://shang.qq.com/wpa/qunwpa?idkey=ef1dcf99efe9fe2cbb596ec743daa748f9296c1206bd19c64090ffe35a5e0ff9)

## 支持渠道

1. 支付宝 [文档中心](https://openhome.alipay.com/docCenter/docCenter.htm?from=openhomemenu)

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

* V3版 [开发文档](https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pages/Overview.shtml)
    - 基础支付
        * 普通支付（直连模式）
        * 普通支付（服务商模式）
        * 合单支付
        * 账单

## 开发环境
* Windows 10
* VS 2019 16.8.x
* .NET 5.0

## 使用方式

* [查看示例项目](samples/WebApplicationSample)

## 常见问题

* [常见问题及解决方法](https://github.com/essensoft/payment/issues/86)

## 捐赠

[捐赠名单](FUNDING.md)

---

![QrCode](img/payment-qrcode.png)

## 项目地址

- [GitHub](https://github.com/essensoft/payment)
- [Gitee](https://gitee.com/essensoft/payment)

## 开源协议

[MIT](LICENSE).

## 致谢

[Varorbc](https://github.com/Varorbc)
[Alipay](https://github.com/alipay)
