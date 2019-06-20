using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioDataDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryPortfolioDataDeleteModel : AlipayObject
    {
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
    }
}
