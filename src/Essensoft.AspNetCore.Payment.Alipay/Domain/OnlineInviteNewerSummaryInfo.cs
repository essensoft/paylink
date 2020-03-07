using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OnlineInviteNewerSummaryInfo Data Structure.
    /// </summary>
    public class OnlineInviteNewerSummaryInfo : AlipayObject
    {
        /// <summary>
        /// 返佣的扩展字段
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
        /// 日期
        /// </summary>
        [JsonPropertyName("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 当天有效绑卡数量
        /// </summary>
        [JsonPropertyName("user_bind_card_count")]
        public long UserBindCardCount { get; set; }

        /// <summary>
        /// 可结算实名数
        /// </summary>
        [JsonPropertyName("user_cert_settle_count")]
        public long UserCertSettleCount { get; set; }

        /// <summary>
        /// 可结算新登数
        /// </summary>
        [JsonPropertyName("user_new_settle_count")]
        public long UserNewSettleCount { get; set; }
    }
}
