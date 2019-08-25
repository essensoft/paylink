using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppSilanApigrayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSilanApigrayQueryModel : AlipayObject
    {
        /// <summary>
        /// param
        /// </summary>
        [JsonProperty("param_1")]
        public string Param1 { get; set; }
    }
}
