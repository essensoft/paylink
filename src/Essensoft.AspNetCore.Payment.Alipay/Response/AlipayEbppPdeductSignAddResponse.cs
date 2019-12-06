using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppPdeductSignAddResponse.
    /// </summary>
    public class AlipayEbppPdeductSignAddResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝代扣协议ID
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝协议状态。签约成功则返回success
        /// </summary>
        [JsonPropertyName("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 扩展参数，可为空
        /// </summary>
        [JsonPropertyName("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 通知方式设置。
        /// </summary>
        [JsonPropertyName("notify_config")]
        public string NotifyConfig { get; set; }

        /// <summary>
        /// 商户生成的代扣协议ID
        /// </summary>
        [JsonPropertyName("out_agreement_id")]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 支付方式设置
        /// </summary>
        [JsonPropertyName("pay_config")]
        public List<string> PayConfig { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonPropertyName("sign_date")]
        public string SignDate { get; set; }
    }
}
