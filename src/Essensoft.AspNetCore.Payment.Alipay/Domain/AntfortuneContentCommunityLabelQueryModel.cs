using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntfortuneContentCommunityLabelQueryModel Data Structure.
    /// </summary>
    public class AntfortuneContentCommunityLabelQueryModel : AlipayObject
    {
        /// <summary>
        /// 标签场景
        /// </summary>
        [JsonPropertyName("label_scene")]
        public string LabelScene { get; set; }
    }
}
