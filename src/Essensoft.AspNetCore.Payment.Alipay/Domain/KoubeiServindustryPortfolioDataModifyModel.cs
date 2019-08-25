using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioDataModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryPortfolioDataModifyModel : AlipayObject
    {
        /// <summary>
        /// 头图素材ID
        /// </summary>
        [JsonProperty("cover_media_id")]
        public string CoverMediaId { get; set; }

        /// <summary>
        /// 头图素材type,枚举(PICTURE/VIDEO),更改头图时必传
        /// </summary>
        [JsonProperty("cover_media_type")]
        public string CoverMediaType { get; set; }

        /// <summary>
        /// 作品集id
        /// </summary>
        [JsonProperty("portfolio_id")]
        public string PortfolioId { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("portfolio_operator_info")]
        public PortfolioOperatorInfo PortfolioOperatorInfo { get; set; }

        /// <summary>
        /// 作品集门店关系&展示权重,需要传要关联的全部店铺,更新模式为覆盖
        /// </summary>
        [JsonProperty("portfolio_shops")]
        public List<PortfolioShop> PortfolioShops { get; set; }

        /// <summary>
        /// 作品集标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
