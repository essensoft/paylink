using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketCommodityQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务插件ID
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 服务创建者ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
