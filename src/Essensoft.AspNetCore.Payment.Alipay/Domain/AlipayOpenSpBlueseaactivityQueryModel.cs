using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSpBlueseaactivityQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenSpBlueseaactivityQueryModel : AlipayObject
    {
        /// <summary>
        /// 申请单Id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
