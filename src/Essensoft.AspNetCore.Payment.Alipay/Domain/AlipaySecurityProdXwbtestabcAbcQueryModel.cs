using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdXwbtestabcAbcQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdXwbtestabcAbcQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("xwb")]
        public string Xwb { get; set; }
    }
}
