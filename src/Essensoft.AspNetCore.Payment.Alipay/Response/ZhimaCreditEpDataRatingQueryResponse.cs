using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpDataRatingQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDataRatingQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 评估额度，单位为人民币分。只有在decision =ACCEPT才会有值，其它情况为空
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 咨询成功返回SUCCESS；当decision为空时，会给出两种业务原因code，一种是PERMISSION_DENIED，一种是NO_DATA；枚举值：SUCCESS，PERMISSION_DENIED，NO_DATA；
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 企业的信用等级
        /// </summary>
        [JsonPropertyName("credit_level")]
        public string CreditLevel { get; set; }

        /// <summary>
        /// 风控决策结果，评估通过，没有风险返回ACCEPT； 拒绝，有风险返回REJECT。当企业不存在或者其他情况可能为空
        /// </summary>
        [JsonPropertyName("decision")]
        public string Decision { get; set; }

        /// <summary>
        /// 企业被拒绝，存放拒绝原因
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 芝麻企业数据评估订单号
        /// </summary>
        [JsonPropertyName("relation_order_no")]
        public string RelationOrderNo { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，商户要保证其唯一性，可以传入流水号。建议：前面几位字符是商户自定义的简称，中间可以使用一段日期，结尾可以使用一个序列号。
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
