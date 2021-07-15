using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollCreateResponse.
    /// </summary>
    public class AlipayMarketingRecruitEnrollCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 报名ID
        /// </summary>
        [JsonPropertyName("enroll_id")]
        public string EnrollId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
