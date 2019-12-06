using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GradeDiscountPoint Data Structure.
    /// </summary>
    public class GradeDiscountPoint : AlipayObject
    {
        /// <summary>
        /// 蚂蚁会员权益配置的ID
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public long BenefitId { get; set; }

        /// <summary>
        /// 各个等级的等级折扣后的积分
        /// </summary>
        [JsonPropertyName("discount_point")]
        public string DiscountPoint { get; set; }

        /// <summary>
        /// 蚂蚁会员等级
        /// </summary>
        [JsonPropertyName("grade")]
        public string Grade { get; set; }
    }
}
