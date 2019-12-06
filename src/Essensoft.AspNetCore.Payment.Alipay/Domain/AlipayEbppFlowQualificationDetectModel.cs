using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppFlowQualificationDetectModel Data Structure.
    /// </summary>
    public class AlipayEbppFlowQualificationDetectModel : AlipayObject
    {
        /// <summary>
        /// 需要校验的用户手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 需要校验的产品id
        /// </summary>
        [JsonPropertyName("product_id")]
        public List<string> ProductId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
