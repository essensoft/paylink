using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollCloseModel Data Structure.
    /// </summary>
    public class AlipayMarketingRecruitEnrollCloseModel : AlipayObject
    {
        /// <summary>
        /// 报名ID
        /// </summary>
        [JsonPropertyName("enroll_id")]
        public string EnrollId { get; set; }
    }
}
