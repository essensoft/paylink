using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 获取平台证书列表
    /// <para><a href="https://wechatpay-api.gitbook.io/wechatpay-api-v3/jie-kou-wen-dang/ping-tai-zheng-shu">获取平台证书列表</a></para>
    /// </summary>
    public class WeChatPayCertificatesResponse : WeChatPayResponse
    {
        [JsonPropertyName("data")]
        public List<Certificate> Certificates { get; set; }
    }
}
