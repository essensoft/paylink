using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdTestModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdAlipaySecurityProdTestModel : AlipayObject
    {
        /// <summary>
        /// ddd
        /// </summary>
        [JsonProperty("cds")]
        public List<string> Cds { get; set; }

        /// <summary>
        /// aaa
        /// </summary>
        [JsonProperty("ddd")]
        public string Ddd { get; set; }
    }
}
