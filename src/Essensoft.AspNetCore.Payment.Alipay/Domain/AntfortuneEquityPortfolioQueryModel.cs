using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneEquityPortfolioQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneEquityPortfolioQueryModel : AlipayObject
    {
        /// <summary>
        /// 组合ID
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId { get; set; }
    }
}
