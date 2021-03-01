using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 获取平台证书列表 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wechatpay/wechatpay5_1.shtml">获取平台证书列表</a></para>
    /// </remarks>
    public class WeChatPayCertificatesResponse : WeChatPayResponse
    {
        [JsonPropertyName("data")]
        public List<Certificate> Certificates { get; set; }
    }
}
