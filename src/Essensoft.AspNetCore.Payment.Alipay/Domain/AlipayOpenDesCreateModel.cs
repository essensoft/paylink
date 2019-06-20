using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenDesCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenDesCreateModel : AlipayObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonProperty("des")]
        public List<GavintestNewLeveaOne> Des { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [JsonProperty("test")]
        public List<bool> Test { get; set; }
    }
}
