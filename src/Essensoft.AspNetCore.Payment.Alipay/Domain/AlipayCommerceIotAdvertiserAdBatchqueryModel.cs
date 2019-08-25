using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserAdBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 是否只要总大小
        /// </summary>
        [JsonProperty("only_total")]
        public bool OnlyTotal { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小(<=50)
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
