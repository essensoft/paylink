using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvchannelBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionAdvchannelBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 广告ID
        /// </summary>
        [JsonProperty("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 每页记录数，默认10，最大100
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }
    }
}
