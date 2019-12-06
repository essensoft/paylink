using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryModifyModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosCategoryModifyModel : AlipayObject
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        [JsonPropertyName("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 菜类名称
        /// </summary>
        [JsonPropertyName("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
