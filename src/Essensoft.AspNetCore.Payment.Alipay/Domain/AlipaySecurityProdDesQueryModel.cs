using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdDesQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdDesQueryModel : AlipayObject
    {
        /// <summary>
        /// 121
        /// </summary>
        [JsonProperty("com")]
        public GavinTestnew Com { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("test")]
        public List<string> Test { get; set; }
    }
}
