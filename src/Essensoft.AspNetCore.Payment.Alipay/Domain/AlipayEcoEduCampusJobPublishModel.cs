using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduCampusJobPublishModel Data Structure.
    /// </summary>
    public class AlipayEcoEduCampusJobPublishModel : AlipayObject
    {
        /// <summary>
        /// 过期时间(毫秒数)
        /// </summary>
        [JsonPropertyName("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 刷新时间(毫秒数)
        /// </summary>
        [JsonPropertyName("gmt_refresh")]
        public string GmtRefresh { get; set; }

        /// <summary>
        /// 职位来源方编码
        /// </summary>
        [JsonPropertyName("source_code")]
        public string SourceCode { get; set; }

        /// <summary>
        /// 职位在合作方的ID
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }
    }
}
