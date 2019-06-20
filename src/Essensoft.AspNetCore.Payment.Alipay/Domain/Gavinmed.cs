using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Gavinmed Data Structure.
    /// </summary>
    [Serializable]
    public class Gavinmed : AlipayObject
    {
        /// <summary>
        /// 复杂类型嵌入
        /// </summary>
        [JsonProperty("meds")]
        public List<GavintestNewLeveaOne> Meds { get; set; }

        /// <summary>
        /// 退换货
        /// </summary>
        [JsonProperty("str")]
        public string Str { get; set; }
    }
}
