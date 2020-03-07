using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OfflineInviteNewerSummaryInfo Data Structure.
    /// </summary>
    public class OfflineInviteNewerSummaryInfo : AlipayObject
    {
        /// <summary>
        /// 返佣扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 二级渠道
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 一级渠道
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 结算日期
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 绑卡数量
        /// </summary>
        [JsonPropertyName("user_bind_card_count")]
        public long UserBindCardCount { get; set; }

        /// <summary>
        /// 可结算的绑卡数量
        /// </summary>
        [JsonPropertyName("user_bind_card_settle_count")]
        public long UserBindCardSettleCount { get; set; }

        /// <summary>
        /// 实名用户数
        /// </summary>
        [JsonPropertyName("user_cert_count")]
        public long UserCertCount { get; set; }

        /// <summary>
        /// 可结算实名用户数
        /// </summary>
        [JsonPropertyName("user_cert_settle_count")]
        public long UserCertSettleCount { get; set; }

        /// <summary>
        /// 权益核销用户数
        /// </summary>
        [JsonPropertyName("user_consume_count")]
        public long UserConsumeCount { get; set; }

        /// <summary>
        /// 可结算核销用户数
        /// </summary>
        [JsonPropertyName("user_consume_settle_count")]
        public long UserConsumeSettleCount { get; set; }

        /// <summary>
        /// 权益领取用户数
        /// </summary>
        [JsonPropertyName("user_prize_count")]
        public long UserPrizeCount { get; set; }
    }
}
