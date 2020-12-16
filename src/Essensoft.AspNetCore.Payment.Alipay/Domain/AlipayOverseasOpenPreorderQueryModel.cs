using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasOpenPreorderQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasOpenPreorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 预缴费单号
        /// </summary>
        [JsonPropertyName("pre_order_id")]
        public string PreOrderId { get; set; }
    }
}
