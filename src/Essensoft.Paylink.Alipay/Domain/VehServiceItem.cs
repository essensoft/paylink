using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VehServiceItem Data Structure.
    /// </summary>
    public class VehServiceItem : AlipayObject
    {
        /// <summary>
        /// 活动信息列表
        /// </summary>
        [JsonPropertyName("activity_items")]
        public VehActivityItem ActivityItems { get; set; }

        /// <summary>
        /// key属性的描述信息 支付宝支付(ALI_PAY)、 在线缴费(ONLINE_PAY)、 活动(ACTIVITY)
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 支持的服务KEY ALI_PAY(支付宝支付)、 ONLINE_PAY(在线缴费)、 ACTIVITY(活动)
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
