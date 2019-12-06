using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IntroductionInfo Data Structure.
    /// </summary>
    public class IntroductionInfo : AlipayObject
    {
        /// <summary>
        /// 商品详情-商家介绍图片地址列表
        /// </summary>
        [JsonPropertyName("image_urls")]
        public List<string> ImageUrls { get; set; }

        /// <summary>
        /// 商品详情-商家介绍标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
