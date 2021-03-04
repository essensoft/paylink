using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppNotifyVerifyModel Data Structure.
    /// </summary>
    public class AlipayOpenAppNotifyVerifyModel : AlipayObject
    {
        /// <summary>
        /// 通知id
        /// </summary>
        [JsonPropertyName("notify_id")]
        public string NotifyId { get; set; }
    }
}
