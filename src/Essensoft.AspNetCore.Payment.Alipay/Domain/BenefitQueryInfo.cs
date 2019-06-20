using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BenefitQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitQueryInfo : AlipayObject
    {
        /// <summary>
        /// 权益描述
        /// </summary>
        [JsonProperty("benefit_desc")]
        public string BenefitDesc { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonProperty("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 权益面额
        /// </summary>
        [JsonProperty("beneft_price")]
        public string BeneftPrice { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 其他信息，为key-value格式，格式为json
        /// </summary>
        [JsonProperty("other_infos")]
        public string OtherInfos { get; set; }

        /// <summary>
        /// 每人限领数量
        /// </summary>
        [JsonProperty("person_limit")]
        public string PersonLimit { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [JsonProperty("total_quantity")]
        public string TotalQuantity { get; set; }
    }
}
