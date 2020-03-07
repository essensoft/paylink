using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportOilproductInfoQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportOilproductInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 来源
        /// </summary>
        [JsonPropertyName("agent")]
        public string Agent { get; set; }

        /// <summary>
        /// 扩展字段，json格式字符串
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 油站门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
