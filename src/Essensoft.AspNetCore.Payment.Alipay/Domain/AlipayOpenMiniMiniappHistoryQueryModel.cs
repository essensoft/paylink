using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappHistoryQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniMiniappHistoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 管控的令牌
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 请求的列表长度
        /// </summary>
        [JsonPropertyName("size")]
        public string Size { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
