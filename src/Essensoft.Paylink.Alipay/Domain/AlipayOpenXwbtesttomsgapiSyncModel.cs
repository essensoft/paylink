using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenXwbtesttomsgapiSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenXwbtesttomsgapiSyncModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("xwb")]
        public string Xwb { get; set; }
    }
}
