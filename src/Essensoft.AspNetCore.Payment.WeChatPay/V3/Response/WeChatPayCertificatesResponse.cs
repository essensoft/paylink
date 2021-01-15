using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Response
{
    /// <summary>
    /// 获取平台证书列表
    /// https://wechatpay-api.gitbook.io/wechatpay-api-v3/jie-kou-wen-dang/ping-tai-zheng-shu
    /// </summary>
    public class WeChatPayCertificatesResponse : WeChatPayResponse
    {
        [JsonPropertyName("data")]
        public List<Certificate> Certificates { get; set; }
    }
}
