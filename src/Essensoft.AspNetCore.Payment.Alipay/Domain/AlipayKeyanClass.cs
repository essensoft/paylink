using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayKeyanClass Data Structure.
    /// </summary>
    public class AlipayKeyanClass : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
