using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneTradeConsultResponse.
    /// </summary>
    public class ZhimaCreditEpSceneTradeConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 评估结果： ACCEPT：没有风险， REJECT：有风险，  REVIEW：需要面签
        /// </summary>
        [JsonPropertyName("decision")]
        public string Decision { get; set; }

        /// <summary>
        /// 芝麻企业信用评估订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 评估结果为REJECT时的原因说明，支持以下原因：SCORE_REJECT ：分数不准入
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }
    }
}
