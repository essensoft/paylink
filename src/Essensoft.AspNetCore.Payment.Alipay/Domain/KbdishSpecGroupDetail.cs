using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishSpecGroupDetail Data Structure.
    /// </summary>
    public class KbdishSpecGroupDetail : AlipayObject
    {
        /// <summary>
        /// 规格标签id
        /// </summary>
        [JsonPropertyName("spec_id")]
        public string SpecId { get; set; }

        /// <summary>
        /// 规格标签的名称
        /// </summary>
        [JsonPropertyName("spec_name")]
        public string SpecName { get; set; }
    }
}
