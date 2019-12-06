using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbtstabcQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppXwbtstabcQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("xwbaa")]
        public string Xwbaa { get; set; }
    }
}
