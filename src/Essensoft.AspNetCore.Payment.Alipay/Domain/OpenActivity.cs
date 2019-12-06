using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenActivity Data Structure.
    /// </summary>
    public class OpenActivity : AlipayObject
    {
        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonPropertyName("activity_end_date")]
        public string ActivityEndDate { get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [JsonPropertyName("activity_start_date")]
        public string ActivityStartDate { get; set; }

        /// <summary>
        /// 活动验证状态  0，未检测  1，未通过  2，已通过
        /// </summary>
        [JsonPropertyName("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
