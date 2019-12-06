using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLifeLabelDeleteModel : AlipayObject
    {
        /// <summary>
        /// 标签id, 只支持生活号自定义标签
        /// </summary>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }
    }
}
