using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppFlowQualificationDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppFlowQualificationDetectModel : AlipayObject
    {
        /// <summary>
        /// 需要校验的用户手机号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 需要校验的产品id
        /// </summary>
        [JsonProperty("product_id")]
        public List<string> ProductId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
