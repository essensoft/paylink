using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportNotifycenterNotifyuserQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportNotifycenterNotifyuserQueryModel : AlipayObject
    {
        /// <summary>
        /// 订阅服务唯一标识
        /// </summary>
        [JsonPropertyName("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 订阅实体的值，ETC订阅实体为人，则为user_id
        /// </summary>
        [JsonPropertyName("notify_object")]
        public string NotifyObject { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
