using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserMaterialBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 查询总数
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
