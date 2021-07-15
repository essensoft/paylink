using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingRecruitEnrollQueryModel : AlipayObject
    {
        /// <summary>
        /// 报名ID，此参数和out_biz_no至少传一个，优先取enroll_id
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
