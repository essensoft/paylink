using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneRatingQueryResponse.
    /// </summary>
    public class ZhimaCreditEpSceneRatingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 评估额度，单位为人民币分。只有在order_status=FINISH且在评估流程中credit_category对应的场景有额度时才会有值，其它情况为空
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 用户的信用层级。只有部分合作商户有输出，其它商户为空
        /// </summary>
        [JsonPropertyName("credit_level")]
        public string CreditLevel { get; set; }

        /// <summary>
        /// 风控决策结果，只有在order_status=FINISH时有值。评估通过，没有风险返回ACCEPT； 拒绝，有风险 返回REJECT；无法评估返回REVIEW。
        /// </summary>
        [JsonPropertyName("decision")]
        public string Decision { get; set; }

        /// <summary>
        /// 如果评估流程走的是企业评估流程，并且成功走完全流程，将会返回企业的以下两个公开信息(公开信息无需脱敏)：  ep_name：企业名称,  ep_cert_no：企业证件号
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 芝麻企业信用评估订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态。初始化即进行中返回INIT；评估流程结束返回FINISH；评估流程异常或终止返回CLOSE。
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商户请求订单号。
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 评估结果为REJECT时的原因说明。 支持以下原因： SCORE_REJECT ：分数不准入； CERTIFY_NOT_PASS：企业认证不通过。
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 芝麻信用评分，分值在[1000,2000]之间。如果无分则返回N/A。目前暂停输出。
        /// </summary>
        [JsonPropertyName("zm_score")]
        public string ZmScore { get; set; }
    }
}
