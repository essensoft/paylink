using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PromoDeliveryInfo Data Structure.
    /// </summary>
    public class PromoDeliveryInfo : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 展位码:boothCode表达的是具体渠道所属的展位码。例如：支付结果页PAYMENT_RESULT
        /// </summary>
        [JsonPropertyName("booth_code")]
        public string BoothCode { get; set; }

        /// <summary>
        /// 可投放的渠道标识. 说明： 针对不同的boot_code，channel值各不相同.接口使用者可以认为channel是不同booth_code展位下的渠道的唯一标识。 例如： booth_code为PAYMENT_RESULT。 channel为某个商户的pid。
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonPropertyName("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 投放状态.  枚举值： ACTIVE: 生效的投放。 INACTIVE: 失效的投放。
        /// </summary>
        [JsonPropertyName("delivery_status")]
        public string DeliveryStatus { get; set; }
    }
}
