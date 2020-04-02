using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppIndustryAntforestEventSendModel Data Structure.
    /// </summary>
    public class AlipayEbppIndustryAntforestEventSendModel : AlipayObject
    {
        /// <summary>
        /// 用于标识行业-蚂蚁森林能量事件的类别
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
