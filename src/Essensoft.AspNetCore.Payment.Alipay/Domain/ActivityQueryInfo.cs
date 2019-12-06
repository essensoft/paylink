using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ActivityQueryInfo Data Structure.
    /// </summary>
    public class ActivityQueryInfo : AlipayObject
    {
        /// <summary>
        /// 新用户活动模版
        /// </summary>
        [JsonPropertyName("new_user_template")]
        public string NewUserTemplate { get; set; }

        /// <summary>
        /// 老用户活动模版
        /// </summary>
        [JsonPropertyName("old_user_template")]
        public string OldUserTemplate { get; set; }

        /// <summary>
        /// 查询的小程序id
        /// </summary>
        [JsonPropertyName("query_app_id")]
        public string QueryAppId { get; set; }
    }
}
