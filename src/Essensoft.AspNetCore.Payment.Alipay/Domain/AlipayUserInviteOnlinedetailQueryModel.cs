using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserInviteOnlinedetailQueryModel Data Structure.
    /// </summary>
    public class AlipayUserInviteOnlinedetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 页号
        /// </summary>
        [JsonPropertyName("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页大小，page_size上限500，当大于500时，最多返回500条记录
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

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
