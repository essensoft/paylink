using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniDataSummaryQueryResponse.
    /// </summary>
    public class AlipayOpenMiniDataSummaryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 页面访问次数
        /// </summary>
        [JsonPropertyName("app_pv")]
        public long AppPv { get; set; }

        /// <summary>
        /// 当日使用人数
        /// </summary>
        [JsonPropertyName("app_uv")]
        public long AppUv { get; set; }

        /// <summary>
        /// 人均停留时长
        /// </summary>
        [JsonPropertyName("avg_stay_time_per_user")]
        public long AvgStayTimePerUser { get; set; }

        /// <summary>
        /// 次均停留时长
        /// </summary>
        [JsonPropertyName("avg_stay_time_per_visit")]
        public long AvgStayTimePerVisit { get; set; }

        /// <summary>
        /// 累计使用次数
        /// </summary>
        [JsonPropertyName("launch_cnt")]
        public long LaunchCnt { get; set; }

        /// <summary>
        /// 累计使用次数
        /// </summary>
        [JsonPropertyName("launch_cnt_dst")]
        public long LaunchCntDst { get; set; }

        /// <summary>
        /// 新增用户数
        /// </summary>
        [JsonPropertyName("new_user_cnt")]
        public long NewUserCnt { get; set; }

        /// <summary>
        /// 当日分享次数
        /// </summary>
        [JsonPropertyName("share_cnt")]
        public long ShareCnt { get; set; }

        /// <summary>
        /// 累计分享次数
        /// </summary>
        [JsonPropertyName("share_cnt_dst")]
        public long ShareCntDst { get; set; }

        /// <summary>
        /// 当日分享人数
        /// </summary>
        [JsonPropertyName("share_user_cnt")]
        public long ShareUserCnt { get; set; }

        /// <summary>
        /// 累计分享人数
        /// </summary>
        [JsonPropertyName("share_user_cnt_dst")]
        public long ShareUserCntDst { get; set; }

        /// <summary>
        /// 30日活跃人数
        /// </summary>
        [JsonPropertyName("user_cnt_30_d")]
        public long UserCnt30D { get; set; }

        /// <summary>
        /// 7日活跃人数
        /// </summary>
        [JsonPropertyName("user_cnt_7_d")]
        public long UserCnt7D { get; set; }

        /// <summary>
        /// 累计使用人数
        /// </summary>
        [JsonPropertyName("user_cnt_dst")]
        public long UserCntDst { get; set; }
    }
}
