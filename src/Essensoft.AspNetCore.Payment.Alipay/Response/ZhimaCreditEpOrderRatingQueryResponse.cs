using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpOrderRatingQueryResponse.
    /// </summary>
    public class ZhimaCreditEpOrderRatingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 评估额度;  单位为人民币分；
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 用户的信用层级；部分行业场景输出，使用前请先跟对接BD沟通该行业场景下是否会输出该信用层级以及层级的值范围。
        /// </summary>
        [JsonPropertyName("credit_level")]
        public string CreditLevel { get; set; }

        /// <summary>
        /// 风控决策结果：  ACCEPT：通过，没有风险；  REJECT：拒绝，有风险 ；  REVIEW:无法评估；
        /// </summary>
        [JsonPropertyName("decision")]
        public string Decision { get; set; }

        /// <summary>
        /// 订单查询返回扩展信息，根据特定场景下允许传回企业三要素： ep_name：企业名称； ep_cert_type：企业证件类型，目前支持：NATIONAL_LEGAL---工商注册号 ,NATIONAL_LEGAL_MERGE---社会统一信用代码; ep_cert_no：企业证件号
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 芝麻企业信用评估订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态   INIT:初始化，  FINISH:订单完成，  CLOSE:订单关闭，已失败 。
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 关联的商户订单唯一标识，64位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性。
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 评估结果为REJECT时的原因说明，  支持以下原因：  SCORE_REJECT ：分数不准入
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 被查询企业的芝麻信用评分，分值在[1000,2000]之间。如果无分则返回N/A。签约时决定是否输出
        /// </summary>
        [JsonPropertyName("zm_score")]
        public string ZmScore { get; set; }
    }
}
