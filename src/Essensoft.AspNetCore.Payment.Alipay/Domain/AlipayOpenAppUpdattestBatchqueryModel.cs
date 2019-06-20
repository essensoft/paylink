using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppUpdattestBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppUpdattestBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 64
        /// </summary>
        [JsonProperty("campus_card")]
        public string CampusCard { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonProperty("s")]
        public string S { get; set; }
    }
}
