using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbtestabcQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppXwbtestabcQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("testabc")]
        public string Testabc { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("xwb")]
        public string Xwb { get; set; }
    }
}
