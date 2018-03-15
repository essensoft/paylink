using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusCreateModel Data Structure.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusCreateModel : AlipayObject
    {
        /// <summary>
        /// ISV插件ID
        /// </summary>
        [JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 作品列表信息
        /// </summary>
        [JsonProperty("opuses")]
        public List<OpusInfo> Opuses { get; set; }

        /// <summary>
        /// 作品集ID
        /// </summary>
        [JsonProperty("portfolio_id")]
        public string PortfolioId { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("portfolio_operator_info")]
        public PortfolioOperatorInfo PortfolioOperatorInfo { get; set; }
    }
}
