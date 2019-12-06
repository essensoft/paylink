using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeLawsuitDetailQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeLawsuitDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 涉诉类型明细ID，对应字段值：裁判文书id（cpwsId)，当事人id（partyId)，执行公告id(zxggId)，失信公告id(shixinId)，曝光台id(bgtId)
        /// </summary>
        [JsonPropertyName("lawsuit_id")]
        public string LawsuitId { get; set; }

        /// <summary>
        /// 涉诉类型包括：裁判文书（cpws)，当事人（party)，执行公告(zxgg)，失信公告(sxgg)，曝光台(bgt)
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
