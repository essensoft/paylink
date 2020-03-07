using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategoryCreateModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosCategoryCreateModel : AlipayObject
    {
        /// <summary>
        /// 菜类名称
        /// </summary>
        [JsonPropertyName("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
