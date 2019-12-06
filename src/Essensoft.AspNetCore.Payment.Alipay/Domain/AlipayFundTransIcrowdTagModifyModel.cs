using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransIcrowdTagModifyModel Data Structure.
    /// </summary>
    public class AlipayFundTransIcrowdTagModifyModel : AlipayObject
    {
        /// <summary>
        /// 手机号码，与user_id不可同时为空
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 标签编码
        /// </summary>
        [JsonPropertyName("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签的值
        /// </summary>
        [JsonPropertyName("tag_value")]
        public string TagValue { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，与mobile不可同时为空
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
