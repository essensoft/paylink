using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserInviteOfflinesummaryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserInviteOfflinesummaryQueryModel : AlipayObject
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
