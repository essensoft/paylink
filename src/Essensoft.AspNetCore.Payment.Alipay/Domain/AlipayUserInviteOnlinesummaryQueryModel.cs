using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserInviteOnlinesummaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserInviteOnlinesummaryQueryModel : AlipayObject
    {
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
    }
}
