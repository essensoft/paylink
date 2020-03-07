using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaymentAbilityQueryResponse Data Structure.
    /// </summary>
    public class PaymentAbilityQueryResponse : AlipayObject
    {
        /// <summary>
        /// 附加信息，json格式字符串。暂时包含信息：是否是支付宝钱包用户，是否是数字娱乐行业活跃用户。
        /// </summary>
        [JsonPropertyName("extra_infos")]
        public string ExtraInfos { get; set; }

        /// <summary>
        /// 接口返回的支付能力等级
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 返回的单据号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
