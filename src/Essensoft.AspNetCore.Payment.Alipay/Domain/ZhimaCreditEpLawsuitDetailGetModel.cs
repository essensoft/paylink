using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpLawsuitDetailGetModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpLawsuitDetailGetModel : AlipayObject
    {
        /// <summary>
        /// 涉诉id
        /// </summary>
        [JsonPropertyName("lawsuit_id")]
        public string LawsuitId { get; set; }

        /// <summary>
        /// 涉诉类型。枚举值：cpws-裁判文书; zxgg-执行公告; sxgg-失信公告; ktgg-开庭公告; fygg-法院公告; ajlc-案件流程信息; bgt-曝光台
        /// </summary>
        [JsonPropertyName("lawsuit_type")]
        public string LawsuitType { get; set; }

        /// <summary>
        /// 产品码，直接使用［示例］给出的值
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户请求的唯一标志，64位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性，对于用户使用相同transaction_id的查询，芝麻在一天（86400秒）内返回首次查询数据，超过有效期的查询即为无效并返回异常，有效期内的重复查询不重新计费
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }
}
