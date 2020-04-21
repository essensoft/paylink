using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioDataDeleteModel Data Structure.
    /// </summary>
    public class KoubeiServindustryPortfolioDataDeleteModel : AlipayObject
    {
        /// <summary>
        /// 作品集id
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
