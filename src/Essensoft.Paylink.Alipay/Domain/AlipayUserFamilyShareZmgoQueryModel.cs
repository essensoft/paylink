using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserFamilyShareZmgoQueryModel Data Structure.
    /// </summary>
    public class AlipayUserFamilyShareZmgoQueryModel : AlipayObject
    {
        /// <summary>
        /// 默认未false。设置为true时同时查询个人版协议
        /// </summary>
        [JsonPropertyName("enable_personal")]
        public bool EnablePersonal { get; set; }

        /// <summary>
        /// 共享关系接入场景，例如健康卡family_health
        /// </summary>
        [JsonPropertyName("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 芝麻GO模版ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
