using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QuoteInfo Data Structure.
    /// </summary>
    [Serializable]
    public class QuoteInfo : AlipayObject
    {
        /// <summary>
        /// 238810000000049704774
        /// </summary>
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [JsonProperty("quote_biz_id")]
        public string QuoteBizId { get; set; }
    }
}
