using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PortfolioInfoOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class PortfolioInfoOpenModel : AlipayObject
    {
        /// <summary>
        /// 头图素材id
        /// </summary>
        [JsonProperty("cover_image_id")]
        public string CoverImageId { get; set; }

        /// <summary>
        /// 头图素材type；  枚举（PICTURE/VIDEO）
        /// </summary>
        [JsonProperty("cover_image_type")]
        public string CoverImageType { get; set; }

        /// <summary>
        /// 头图链接
        /// </summary>
        [JsonProperty("cover_image_url")]
        public string CoverImageUrl { get; set; }

        /// <summary>
        /// 作品集id
        /// </summary>
        [JsonProperty("portfolio_id")]
        public string PortfolioId { get; set; }

        /// <summary>
        /// 作品集标题
        /// </summary>
        [JsonProperty("portfolio_title")]
        public string PortfolioTitle { get; set; }
    }
}
