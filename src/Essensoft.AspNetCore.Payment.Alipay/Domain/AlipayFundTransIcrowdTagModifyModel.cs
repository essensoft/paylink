using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransIcrowdTagModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransIcrowdTagModifyModel : AlipayObject
    {
        /// <summary>
        /// 手机号码，与user_id不可同时为空
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 标签编码
        /// </summary>
        [JsonProperty("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签的值
        /// </summary>
        [JsonProperty("tag_value")]
        public string TagValue { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，与mobile不可同时为空
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
