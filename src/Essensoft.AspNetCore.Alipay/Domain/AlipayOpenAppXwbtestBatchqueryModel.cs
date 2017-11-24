using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbtestBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppXwbtestBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 1sd
        /// </summary>
        [JsonProperty("xwb")]
        public string Xwb { get; set; }
    }
}
