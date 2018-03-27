using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateBenefitInfoDTO Data Structure.
    /// </summary>
    public class TemplateBenefitInfoDTO : AlipayObject
    {
        /// <summary>
        /// 权益描述信息
        /// </summary>
        [JsonProperty("benefit_desc")]
        public List<string> BenefitDesc { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 权益描述
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
