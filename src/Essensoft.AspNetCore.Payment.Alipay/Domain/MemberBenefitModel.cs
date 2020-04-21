using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MemberBenefitModel Data Structure.
    /// </summary>
    public class MemberBenefitModel : AlipayObject
    {
        /// <summary>
        /// 权益描述信息
        /// </summary>
        [JsonPropertyName("benefit_desc")]
        public List<string> BenefitDesc { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 权益描述
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
