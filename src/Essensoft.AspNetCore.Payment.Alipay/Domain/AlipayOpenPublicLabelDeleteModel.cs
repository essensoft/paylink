using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLabelDeleteModel : AlipayObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
