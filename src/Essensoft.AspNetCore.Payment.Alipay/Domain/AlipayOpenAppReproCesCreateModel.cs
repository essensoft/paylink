using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppReproCesCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppReproCesCreateModel : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("comp")]
        public List<GavintestNewLeveaOne> Comp { get; set; }

        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("nam")]
        public Gavinmed Nam { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonProperty("str")]
        public List<string> Str { get; set; }
    }
}
