using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCrowdDataSyncModel Data Structure.
    /// </summary>
    public class AlipayMarketingCrowdDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 人群来源业务方，枚举：DATANEST=金融云
        /// </summary>
        [JsonPropertyName("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 人群创建者ID
        /// </summary>
        [JsonPropertyName("create_id")]
        public string CreateId { get; set; }

        /// <summary>
        /// 人群ID
        /// </summary>
        [JsonPropertyName("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 人群名称
        /// </summary>
        [JsonPropertyName("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 人群中的用户数
        /// </summary>
        [JsonPropertyName("crowd_size")]
        public long CrowdSize { get; set; }

        /// <summary>
        /// 人群状态，枚举：INIT=待生成、EFFECTIVE=已生成、DELETE=已删除
        /// </summary>
        [JsonPropertyName("crowd_status")]
        public string CrowdStatus { get; set; }

        /// <summary>
        /// 人群有效期截止时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 人群拥有者ID
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 人群有效期开始时间，标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 人群更新周期，枚举：DAILY=每日更新
        /// </summary>
        [JsonPropertyName("update_circle_type")]
        public string UpdateCircleType { get; set; }
    }
}
