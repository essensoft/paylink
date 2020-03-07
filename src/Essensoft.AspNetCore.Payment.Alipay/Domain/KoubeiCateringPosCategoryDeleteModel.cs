using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryDeleteModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosCategoryDeleteModel : AlipayObject
    {
        /// <summary>
        /// 菜类ID
        /// </summary>
        [JsonPropertyName("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
