using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataDashboardBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataDashboardBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }

        /// <summary>
        /// 每页最大条数，最大每页30条
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }
    }
}
