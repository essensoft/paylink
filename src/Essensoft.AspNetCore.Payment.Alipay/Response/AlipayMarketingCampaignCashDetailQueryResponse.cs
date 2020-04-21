using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCashDetailQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignCashDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动状态，CREATED: 已创建未打款  PAID:已打款  READY:活动已开始  PAUSE:活动已暂停  CLOSED:活动已结束  SETTLE:活动已清算
        /// </summary>
        [JsonPropertyName("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 红包名称
        /// </summary>
        [JsonPropertyName("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 活动号
        /// </summary>
        [JsonPropertyName("crowd_no")]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 原始活动号,商户排查问题时提供的活动依据
        /// </summary>
        [JsonPropertyName("origin_crowd_no")]
        public string OriginCrowdNo { get; set; }

        /// <summary>
        /// 活动文案,用户在账单中看到的红包描述
        /// </summary>
        [JsonPropertyName("prize_msg")]
        public string PrizeMsg { get; set; }

        /// <summary>
        /// 现金红包的发放形式, fixed为固定金额,random为随机金额
        /// </summary>
        [JsonPropertyName("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 活动已发放金额
        /// </summary>
        [JsonPropertyName("send_amount")]
        public string SendAmount { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动总金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 红包总个数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 红包总个数(废弃)
        /// </summary>
        [JsonPropertyName("total_num")]
        public long TotalNum { get; set; }
    }
}
