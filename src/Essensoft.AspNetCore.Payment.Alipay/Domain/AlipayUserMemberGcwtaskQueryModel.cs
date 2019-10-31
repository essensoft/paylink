using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserMemberGcwtaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberGcwtaskQueryModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，16位2088开头。
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 应用id，固定值，用于识别相关调用方的应用来源
        /// </summary>
        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }
    }
}
