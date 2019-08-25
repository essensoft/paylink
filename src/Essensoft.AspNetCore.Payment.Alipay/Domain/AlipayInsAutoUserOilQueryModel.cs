using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoUserOilQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoUserOilQueryModel : AlipayObject
    {
        /// <summary>
        /// 车险开发分配，source+scene_type决定了返回的内容
        /// </summary>
        [JsonProperty("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
