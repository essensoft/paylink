using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLabelModifyModel : AlipayObject
    {
        /// <summary>
        /// 要修改的标签id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 要修改成的标签名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
