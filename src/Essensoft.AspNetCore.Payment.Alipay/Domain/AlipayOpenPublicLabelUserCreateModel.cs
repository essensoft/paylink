using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelUserCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelUserCreateModel : AlipayObject
    {
        /// <summary>
        /// 要绑定的标签Id
        /// </summary>
        [JsonProperty("label_id")]
        public long LabelId { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头长度为16位的字符串
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
