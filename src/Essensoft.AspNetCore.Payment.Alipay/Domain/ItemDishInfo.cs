using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemDishInfo Data Structure.
    /// </summary>
    public class ItemDishInfo : AlipayObject
    {
        /// <summary>
        /// 商品详情-菜品图片中的图片描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 详情图片中，菜品图片列表
        /// </summary>
        [JsonPropertyName("image_urls")]
        public List<string> ImageUrls { get; set; }

        /// <summary>
        /// 详情图片中，菜品标题。请勿超过15汉字，30个字符
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
