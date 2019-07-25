using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicComptestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicComptestCreateModel : AlipayObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("string")]
        public List<GavintestNewLeveaOne> String { get; set; }
    }
}
