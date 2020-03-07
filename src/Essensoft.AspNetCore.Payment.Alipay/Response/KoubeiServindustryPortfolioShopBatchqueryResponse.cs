using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioShopBatchqueryResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioShopBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("portfolio_count")]
        public long PortfolioCount { get; set; }

        /// <summary>
        /// 返回作品集列表
        /// </summary>
        [JsonPropertyName("portfolio_info_list")]
        public List<PortfolioInfoOpenModel> PortfolioInfoList { get; set; }
    }
}
