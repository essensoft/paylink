using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryReservationShopBindModel Data Structure.
    /// </summary>
    public class KoubeiServindustryReservationShopBindModel : AlipayObject
    {
        /// <summary>
        /// 口碑为第三方ISV分配的渠道标识，如K米的渠道为ISV_KMI
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 行业，如KTV，MASSAGE(足疗)等
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 商户在ISV创建的门店id
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 商户在口碑创建的门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
