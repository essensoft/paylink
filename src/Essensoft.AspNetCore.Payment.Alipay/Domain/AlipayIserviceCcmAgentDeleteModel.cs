using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmAgentDeleteModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmAgentDeleteModel : AlipayObject
    {
        /// <summary>
        /// 客服id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
