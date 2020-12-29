using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAccountNegativecardSendModel Data Structure.
    /// </summary>
    public class AlipayUserAccountNegativecardSendModel : AlipayObject
    {
        /// <summary>
        /// 模板参数,键值对，以竖线分割
        /// </summary>
        [JsonPropertyName("arguments")]
        public string Arguments { get; set; }

        /// <summary>
        /// 扩展信息。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 负一屏卡片业务码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
