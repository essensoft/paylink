using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdDesQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdDesQueryModel : AlipayObject
    {
        /// <summary>
        /// 121
        /// </summary>
        [JsonPropertyName("com")]
        public GavinTestnew Com { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("test")]
        public List<string> Test { get; set; }
    }
}
