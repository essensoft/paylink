using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAccountNewbieBenefitConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAccountNewbieBenefitConsultModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息，json格式字符串。
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 手机号码。和user_id二选一必填。
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 模式，用于决策当前请求包含哪些人君。
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 商户支付宝ID
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID。和mobile二选一必填。
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
