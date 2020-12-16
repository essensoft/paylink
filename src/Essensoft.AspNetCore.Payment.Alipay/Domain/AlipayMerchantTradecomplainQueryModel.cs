using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantTradecomplainQueryModel Data Structure.
    /// </summary>
    public class AlipayMerchantTradecomplainQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        [JsonPropertyName("complain_event_id")]
        public string ComplainEventId { get; set; }
    }
}
