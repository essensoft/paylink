<p align="center">
  <a href="https://github.com/essensoft/paylink">
    <img width="96" src="https://cdn.jsdelivr.net/gh/essensoft/paylink@main/logo.png">
  </a>
</p>

<h1 align="center">Paylink</h1>

<div align="center">

一套基于 .NET Core 开发的支付SDK集，它极大简化了API调用及通知的处理流程。

[![Build status][github-action-image]][github-action-url]
[![MIT][license-image]](LICENSE.md)

[github-action-image]: https://img.shields.io/github/workflow/status/essensoft/paylink/build/main.svg?style=flat-square
[github-action-url]: https://github.com/essensoft/paylink/actions/workflows/build.yml?query=branch%3Amain
[license-image]: https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square

</div>

## Paylink NuGet 包

Package  | NuGet | Downloads | TargetFrameworks
-------- | :---- | :-------- | ---------------
[Essensoft.Paylink.Alipay][nuget-alipay-url] | ![NuGet][nuget-alipay-v-image] | ![Downloads][nuget-alipay-dt-image] | ![netstandard2.1][standard2.1-Y-image] ![netcoreapp3.1][netcoreapp3.1-Y-image] ![net5.0][net5.0-Y-image]
[Essensoft.Paylink.WeChatPay][nuget-wechatpay-url] | ![NuGet][nuget-wechatpay-v-image] | ![Downloads][nuget-wechatpay-dt-image] | ![netstandard2.1][standard2.1-Y-image] ![netcoreapp3.1][netcoreapp3.1-Y-image] ![net5.0][net5.0-Y-image]
[Essensoft.Paylink.Security][nuget-security-url] | ![NuGet][nuget-security-v-image] | ![Downloads][nuget-security-dt-image] | ![netstandard2.1][standard2.1-Y-image] ![net5.0][net5.0-Y-image]

[nuget-alipay-url]: https://www.nuget.org/packages/Essensoft.Paylink.Alipay
[nuget-alipay-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-alipay-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Alipay.svg?style=flat-square
[nuget-wechatpay-url]: https://www.nuget.org/packages/Essensoft.Paylink.WeChatPay
[nuget-wechatpay-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.WeChatPay.svg?style=flat-square
[nuget-wechatpay-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.WeChatPay.svg?style=flat-square
[nuget-security-url]: https://www.nuget.org/packages/Essensoft.Paylink.Security
[nuget-security-v-image]: https://img.shields.io/nuget/v/Essensoft.Paylink.Security.svg?style=flat-square
[nuget-security-dt-image]: https://img.shields.io/nuget/dt/Essensoft.Paylink.Security.svg?style=flat-square
[standard2.1-Y-image]: https://img.shields.io/badge/standard2.1-Y-brightgreen.svg?style=flat-square
[netcoreapp3.1-Y-image]: https://img.shields.io/badge/netcoreapp3.1-Y-brightgreen.svg?style=flat-square
[net5.0-Y-image]: https://img.shields.io/badge/net5.0-Y-brightgreen.svg?style=flat-square

---

## Payment NuGet 包

后续不再维护 Payment 包，请迁移至 Paylink 包。
 
Package  | NuGet | Downloads
-------- | :---- | :-------- 
[Essensoft.AspNetCore.Payment.Alipay][nuget-pay-alipay-url] | ![NuGet][nuget-pay-alipay-v-image] | ![Downloads][nuget-pay-alipay-dt-image]
[Essensoft.AspNetCore.Payment.WeChatPay][nuget-pay-wechatpay-url] | ![NuGet][nuget-pay.wechatpay-v-image] | ![Downloads][nuget-pay-wechatpay-dt-image]
[Essensoft.AspNetCore.Payment.Security][nuget-pay-security-url] | ![NuGet][nuget-pay.security-v-image] | ![Downloads][nuget-pay-security-dt-image]

[nuget-pay-alipay-url]: https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Alipay
[nuget-pay-alipay-v-image]: https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.Alipay.svg?style=flat-square
[nuget-pay-alipay-dt-image]: https://img.shields.io/nuget/dt/Essensoft.AspNetCore.Payment.Alipay.svg?style=flat-square
[nuget-pay-wechatpay-url]: https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.WeChatPay
[nuget-pay.wechatpay-v-image]: https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.WeChatPay.svg?style=flat-square
[nuget-pay-wechatpay-dt-image]: https://img.shields.io/nuget/dt/Essensoft.AspNetCore.Payment.WeChatPay.svg?style=flat-square
[nuget-pay-security-url]: https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Security
[nuget-pay.security-v-image]: https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.Security.svg?style=flat-square
[nuget-pay-security-dt-image]: https://img.shields.io/nuget/dt/Essensoft.AspNetCore.Payment.Security.svg?style=flat-square

## 开发环境

* Windows 10
* [Visual Studio 2019 16.10](https://visualstudio.microsoft.com)
* [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)

## 运行环境

- [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)
- [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)

## 使用方式

* [示例项目](samples/WebApplicationSample)

## 捐赠

[捐赠名单](FUNDING.md)

---

<img src="https://cdn.jsdelivr.net/gh/essensoft/paylink@main/qrcode-pay.png" width="600">

## 社区互助

如果您在使用的过程中碰到问题，可以通过下面几个途径寻求帮助，同时我们也鼓励资深用户通过下面的途径给新人提供帮助。

* QQ群
    - [Paylink 交流①群: 522457525](https://shang.qq.com/wpa/qunwpa?idkey=aac56c8f02f54893267d3ac90787c1794a7687f3c31a923812a36b67c4ee6271)
    - [Paylink 交流②群: 204076462](https://shang.qq.com/wpa/qunwpa?idkey=a77c990f2a8fca61f7eaf87ad34eae1a4ac4ebb98968a2602514dfba0c23c108)
    - [Paylink 交流③群: 755039581](https://shang.qq.com/wpa/qunwpa?idkey=ef1dcf99efe9fe2cbb596ec743daa748f9296c1206bd19c64090ffe35a5e0ff9)

* 钉钉群
    - <details>
        <summary>Paylink 交流群: 34090889(点击显示二维码)</summary>
        <img src="https://cdn.jsdelivr.net/gh/essensoft/paylink@main/qrcode-dingtalk.png" width="300">
      </details>

## 支持渠道

1. 支付宝 [文档中心](https://openhome.alipay.com/docCenter/docCenter.htm)

* 同步 [alipay-sdk-net-all](https://github.com/alipay/alipay-sdk-net-all) 所有API。

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
    - ...

* V3版 [开发者文档](https://pay.weixin.qq.com/wiki/doc/apiv3/index.shtml)
    - 基础支付
    - 分账
    - 微信支付分
    - 商户进件（服务商）
    - 基础支付（服务商）
    - 分账（服务商）
    
## 致谢

- [Alipay](https://github.com/alipay)
- [Varorbc](https://github.com/Varorbc)

## 项目地址

- [GitHub](https://github.com/essensoft/paylink)
- [Gitee](https://gitee.com/essensoft/paylink)
