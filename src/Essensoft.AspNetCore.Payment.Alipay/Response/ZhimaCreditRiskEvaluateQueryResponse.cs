using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditRiskEvaluateQueryResponse.
    /// </summary>
    public class ZhimaCreditRiskEvaluateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 风控评估结果[True:准入;False:不准入]
        /// </summary>
        [JsonPropertyName("accessible")]
        public bool Accessible { get; set; }

        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 当准入通过且需要输出免押额度等级时，用该字段表示额度等级。当无法评估额度时，用N/A表述
        /// </summary>
        [JsonPropertyName("limit_level")]
        public string LimitLevel { get; set; }

        /// <summary>
        /// 当准入accessible为False时，用该字段描述原因
        /// </summary>
        [JsonPropertyName("risk_code")]
        public string RiskCode { get; set; }

        /// <summary>
        /// score_level:当准入通过且需要输出用户芝麻分等级时，用该字段表示芝麻分等级。当无芝麻分时，用N/A表述
        /// </summary>
        [JsonPropertyName("score_level")]
        public string ScoreLevel { get; set; }
    }
}
