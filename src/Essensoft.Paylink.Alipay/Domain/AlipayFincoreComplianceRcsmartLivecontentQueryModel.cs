using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartLivecontentQueryModel Data Structure.
    /// </summary>
    public class AlipayFincoreComplianceRcsmartLivecontentQueryModel : AlipayObject
    {
        /// <summary>
        /// app_name为调用方系统名称(英文)，与分配的app_token一起做调用系统合法性校验
        /// </summary>
        [JsonPropertyName("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// app_token为系统分配的密钥，与app_name一起做调用系统合法性校验
        /// </summary>
        [JsonPropertyName("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 审核完成时间开始
        /// </summary>
        [JsonPropertyName("live_audit_time_begain")]
        public string LiveAuditTimeBegain { get; set; }

        /// <summary>
        /// 审核完成结束时间
        /// </summary>
        [JsonPropertyName("live_audit_time_end")]
        public string LiveAuditTimeEnd { get; set; }

        /// <summary>
        /// 直播开始时间的维度-起始查询时间
        /// </summary>
        [JsonPropertyName("live_start_time_begain")]
        public string LiveStartTimeBegain { get; set; }

        /// <summary>
        /// 直播开始时间的维度-截止查询时间
        /// </summary>
        [JsonPropertyName("live_start_time_end")]
        public string LiveStartTimeEnd { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
