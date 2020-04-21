using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaterialInfo Data Structure.
    /// </summary>
    public class MaterialInfo : AlipayObject
    {
        /// <summary>
        /// 素材内容（素材地址或素材KEY）
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 素材ID
        /// </summary>
        [JsonPropertyName("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 素材类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
