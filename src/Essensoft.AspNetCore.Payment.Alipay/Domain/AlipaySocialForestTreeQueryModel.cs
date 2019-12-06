using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialForestTreeQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialForestTreeQueryModel : AlipayObject
    {
        /// <summary>
        /// 种树截止时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 种树开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID。目前该参数服务端没有用
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
