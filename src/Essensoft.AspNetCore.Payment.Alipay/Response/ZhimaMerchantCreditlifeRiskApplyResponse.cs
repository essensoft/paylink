using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantCreditlifeRiskApplyResponse.
    /// </summary>
    public class ZhimaMerchantCreditlifeRiskApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 用户在商端的身份标识，如果在接口的入参中存在该参数，芝麻网关会自动转化
        /// </summary>
        [JsonPropertyName("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 较差、中等、良好、优秀、极好5个级别
        /// </summary>
        [JsonPropertyName("zm_grade")]
        public string ZmGrade { get; set; }

        /// <summary>
        /// 风控结果
        /// </summary>
        [JsonPropertyName("zm_risk")]
        public string ZmRisk { get; set; }

        /// <summary>
        /// 芝麻分
        /// </summary>
        [JsonPropertyName("zm_score")]
        public string ZmScore { get; set; }
    }
}
