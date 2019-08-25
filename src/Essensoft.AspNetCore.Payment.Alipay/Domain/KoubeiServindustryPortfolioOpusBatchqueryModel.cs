using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryPortfolioOpusBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 插件id
        /// </summary>
        [JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 当前页码；页码必须大于等于1；最大值：100
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小;默认值：20；最大值：100
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 作品集id
        /// </summary>
        [JsonProperty("portfolio_id")]
        public string PortfolioId { get; set; }
    }
}
