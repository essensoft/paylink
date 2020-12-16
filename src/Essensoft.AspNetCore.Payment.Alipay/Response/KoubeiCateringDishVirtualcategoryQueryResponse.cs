using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategoryQueryResponse.
    /// </summary>
    public class KoubeiCateringDishVirtualcategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否需要重试，true：需要；false：不需要
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 门店下虚拟类目信息
        /// </summary>
        [JsonPropertyName("shop_info")]
        public KbdishVirtualShopSimplifyInfo ShopInfo { get; set; }
    }
}
