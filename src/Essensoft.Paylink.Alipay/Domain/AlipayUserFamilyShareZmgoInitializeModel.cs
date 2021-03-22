using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserFamilyShareZmgoInitializeModel Data Structure.
    /// </summary>
    public class AlipayUserFamilyShareZmgoInitializeModel : AlipayObject
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 场景ID
        /// </summary>
        [JsonPropertyName("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
