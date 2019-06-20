using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppYiyiyiwuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppYiyiyiwuQueryModel : AlipayObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [JsonProperty("rucan")]
        public string Rucan { get; set; }
    }
}
