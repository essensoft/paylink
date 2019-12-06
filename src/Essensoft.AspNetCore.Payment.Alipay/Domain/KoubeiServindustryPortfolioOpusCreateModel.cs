using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusCreateModel Data Structure.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusCreateModel : AlipayObject
    {
        /// <summary>
        /// ISV插件ID
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 作品列表信息
        /// </summary>
        [JsonPropertyName("opuses")]
        public List<OpusInfo> Opuses { get; set; }

        /// <summary>
        /// 作品集ID
        /// </summary>
        [JsonPropertyName("portfolio_id")]
        public string PortfolioId { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonPropertyName("portfolio_operator_info")]
        public PortfolioOperatorInfo PortfolioOperatorInfo { get; set; }
    }
}
