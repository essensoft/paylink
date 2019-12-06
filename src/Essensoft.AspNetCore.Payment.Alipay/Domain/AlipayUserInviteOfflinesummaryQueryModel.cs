using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserInviteOfflinesummaryQueryModel Data Structure.
    /// </summary>
    public class AlipayUserInviteOfflinesummaryQueryModel : AlipayObject
    {
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
    }
}
