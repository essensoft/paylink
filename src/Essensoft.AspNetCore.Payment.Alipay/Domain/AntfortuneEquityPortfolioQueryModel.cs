using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneEquityPortfolioQueryModel Data Structure.
    /// </summary>
    public class AntfortuneEquityPortfolioQueryModel : AlipayObject
    {
        /// <summary>
        /// 组合ID
        /// </summary>
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }
    }
}
