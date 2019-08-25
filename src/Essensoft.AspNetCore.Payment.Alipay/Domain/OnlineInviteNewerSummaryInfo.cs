using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OnlineInviteNewerSummaryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OnlineInviteNewerSummaryInfo : AlipayObject
    {
        /// <summary>
        /// 返佣的扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 二级渠道
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 一级渠道
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 当天有效绑卡数量
        /// </summary>
        [JsonProperty("user_bind_card_count")]
        public long UserBindCardCount { get; set; }

        /// <summary>
        /// 可结算实名数
        /// </summary>
        [JsonProperty("user_cert_settle_count")]
        public long UserCertSettleCount { get; set; }

        /// <summary>
        /// 可结算新登数
        /// </summary>
        [JsonProperty("user_new_settle_count")]
        public long UserNewSettleCount { get; set; }
    }
}
