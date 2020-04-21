using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneEquityPortfolioQueryModel Data Structure.
    /// </summary>
    public class AntfortuneEquityPortfolioQueryModel : AlipayObject
    {
        /// <summary>
        /// 组合Code
        /// </summary>
        [JsonPropertyName("portfolio_code")]
        public string PortfolioCode { get; set; }

        /// <summary>
        /// 组合ID，已废弃，请使用组合Code参数查询
        /// </summary>
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }
    }
}
