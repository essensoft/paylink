using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppDfsfasDeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDfsfasDeQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("desd")]
        public string Desd { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("desdde")]
        public string Desdde { get; set; }
    }
}
