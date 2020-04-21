using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
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
