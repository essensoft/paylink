using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppFlowModeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppFlowModeQueryModel : AlipayObject
    {
        /// <summary>
        /// json扩展字段
        /// </summary>
        [JsonProperty("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
