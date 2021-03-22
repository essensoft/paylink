using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserFamilyShareAdmittancePreconsultModel Data Structure.
    /// </summary>
    public class AlipayUserFamilyShareAdmittancePreconsultModel : AlipayObject
    {
        /// <summary>
        /// 共享资源ID
        /// </summary>
        [JsonPropertyName("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 标识共享业务接入我的家场景ID
        /// </summary>
        [JsonPropertyName("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
