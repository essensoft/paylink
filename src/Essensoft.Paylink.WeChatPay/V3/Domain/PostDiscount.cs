using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 商户优惠
    /// </summary>
    public class PostDiscount : WeChatPayObject
    {
        /// <summary>
        /// 优惠名称
        /// </summary>
        /// <remarks>
        /// 1、商户优惠项目名称，不超过20个字符。
        /// 2、优惠项目名称不可重复。
        /// <para>示例值：满20减1元 </para>
        /// </remarks>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优惠说明
        /// </summary>
        /// <remarks>
        /// 1、优惠使用条件说明，不超过30个字符。
        /// <para>示例值：不与其他优惠叠加</para>
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        /// <remarks>
        /// 1、商户优惠项目金额，大于等于0，单位为分。
        /// <para>示例值：100</para>
        /// </remarks>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// 优惠数量
        /// </summary>
        /// <remarks>
        /// 优惠的数量，不填时默认为1个。
        /// 特殊规则：数量限制100，不填时默认1
        /// <para>示例值：2</para>
        /// </remarks>
        [JsonPropertyName("count")]
        public uint? Count { get; set; }
    }
}
