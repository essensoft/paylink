using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantComplainGovernmentQueryModel Data Structure.
    /// </summary>
    public class AlipayMerchantComplainGovernmentQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝侧投诉工单号
        /// </summary>
        [JsonPropertyName("complain_event_id")]
        public string ComplainEventId { get; set; }
    }
}
