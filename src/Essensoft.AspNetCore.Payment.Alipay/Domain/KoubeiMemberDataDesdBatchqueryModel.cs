using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMemberDataDesdBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMemberDataDesdBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonProperty("a")]
        public string A { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonProperty("desd")]
        public GavintestNewLeveaOne Desd { get; set; }
    }
}
