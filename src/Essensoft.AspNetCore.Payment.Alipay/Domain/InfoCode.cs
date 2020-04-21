using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InfoCode Data Structure.
    /// </summary>
    public class InfoCode : AlipayObject
    {
        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonPropertyName("risk_description")]
        public string RiskDescription { get; set; }

        /// <summary>
        /// 风险因素编码
        /// </summary>
        [JsonPropertyName("risk_factor_code")]
        public string RiskFactorCode { get; set; }

        /// <summary>
        /// 风险因素名称
        /// </summary>
        [JsonPropertyName("risk_factor_name")]
        public string RiskFactorName { get; set; }

        /// <summary>
        /// 风险度量，子特征风险分，范围 0-10，值越大表示风险越高
        /// </summary>
        [JsonPropertyName("risk_magnitude")]
        public string RiskMagnitude { get; set; }
    }
}
