using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelShopSyncresultQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelShopSyncresultQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部店铺ID
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }
    }
}
