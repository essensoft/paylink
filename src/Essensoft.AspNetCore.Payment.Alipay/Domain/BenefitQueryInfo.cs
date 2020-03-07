using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BenefitQueryInfo Data Structure.
    /// </summary>
    public class BenefitQueryInfo : AlipayObject
    {
        /// <summary>
        /// 权益描述
        /// </summary>
        [JsonPropertyName("benefit_desc")]
        public string BenefitDesc { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [JsonPropertyName("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 权益面额
        /// </summary>
        [JsonPropertyName("beneft_price")]
        public string BeneftPrice { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 其他信息，为key-value格式，格式为json
        /// </summary>
        [JsonPropertyName("other_infos")]
        public string OtherInfos { get; set; }

        /// <summary>
        /// 每人限领数量
        /// </summary>
        [JsonPropertyName("person_limit")]
        public string PersonLimit { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [JsonPropertyName("total_quantity")]
        public string TotalQuantity { get; set; }
    }
}
