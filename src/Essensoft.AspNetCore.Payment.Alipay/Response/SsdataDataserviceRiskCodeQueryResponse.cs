using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskCodeQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskCodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否命中yes/no
        /// </summary>
        [JsonPropertyName("hit")]
        public string Hit { get; set; }

        /// <summary>
        /// 风险码,具体见接口文档
        /// </summary>
        [JsonPropertyName("risk_code")]
        public List<string> RiskCode { get; set; }

        /// <summary>
        /// 调用订单号
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 验证码, 具体见接口文档
        /// </summary>
        [JsonPropertyName("verify_code")]
        public List<string> VerifyCode { get; set; }
    }
}
