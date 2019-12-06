using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioDataCreateModel Data Structure.
    /// </summary>
    public class KoubeiServindustryPortfolioDataCreateModel : AlipayObject
    {
        /// <summary>
        /// ISV插件ID
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 头图素材id
        /// </summary>
        [JsonPropertyName("cover_media_id")]
        public string CoverMediaId { get; set; }

        /// <summary>
        /// 头图素材type;  枚举（PICTURE/VIDEO）
        /// </summary>
        [JsonPropertyName("cover_media_type")]
        public string CoverMediaType { get; set; }

        /// <summary>
        /// 外部作品集ID
        /// </summary>
        [JsonPropertyName("external_portfolio_id")]
        public string ExternalPortfolioId { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonPropertyName("portfolio_operator_info")]
        public PortfolioOperatorInfo PortfolioOperatorInfo { get; set; }

        /// <summary>
        /// 作品集与门店的关系、作品集在门店的展示权重
        /// </summary>
        [JsonPropertyName("portfolio_shops")]
        public List<PortfolioShop> PortfolioShops { get; set; }

        /// <summary>
        /// 作品集标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
