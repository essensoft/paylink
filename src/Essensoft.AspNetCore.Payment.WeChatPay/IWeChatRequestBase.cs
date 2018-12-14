using System;
using System.Collections.Generic;
using System.Text;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// 微信支付请求的基础接口，具体的支付接口和证书支付接口都将从此接口继承
    /// </summary>
    public interface IWeChatRequestBase
    {
        /// <summary>
        /// API接口地址
        /// </summary>
        /// <returns></returns>
        string GetRequestUrl();

        /// <summary>
        /// 检查响应中的签名是否正确，不正确则直接抛出异常
        /// </summary>
        /// <param name="response">响应信息</param>
        /// <param name="options">配置信息</param>
        void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options);
        /// <summary>
        /// 处理通用参数，配置选项中的参数和签名
        /// </summary>
        /// <param name="options">配置选项</param>
        /// <returns>可以直接发送给微信的所有参数</returns>
        WeChatPayDictionary HandleParametersAndSign(WeChatPayOptions options);
    }
}
