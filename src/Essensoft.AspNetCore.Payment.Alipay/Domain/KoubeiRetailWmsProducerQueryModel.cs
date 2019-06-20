using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsProducerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsProducerQueryModel : AlipayObject
    {
        /// <summary>
        /// 页码，分页参数，默认1。
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小，分页参数，默认20
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
