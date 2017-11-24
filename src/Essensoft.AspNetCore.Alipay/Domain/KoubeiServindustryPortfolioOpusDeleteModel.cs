using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusDeleteModel Data Structure.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusDeleteModel : AlipayObject
    {
        /// <summary>
        /// 作品ID列表
        /// </summary>
        [JsonProperty("opus_ids")]
        public List<string> OpusIds { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("portfolio_operator_info")]
        public PortfolioOperatorInfo PortfolioOperatorInfo { get; set; }
    }
}
