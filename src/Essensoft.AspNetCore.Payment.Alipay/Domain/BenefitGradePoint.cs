using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BenefitGradePoint Data Structure.
    /// </summary>
    public class BenefitGradePoint : AlipayObject
    {
        /// <summary>
        /// 蚂蚁会员权益配置的ID
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 蚂蚁会员权益配置在各个用户等级下的折扣积分
        /// </summary>
        [JsonPropertyName("grade_points")]
        public List<GradeDiscountPoint> GradePoints { get; set; }

        /// <summary>
        /// 蚂蚁会员权益配置的原始积分
        /// </summary>
        [JsonPropertyName("original_point")]
        public string OriginalPoint { get; set; }

        /// <summary>
        /// 蚂蚁会员权益的专享等级列表
        /// </summary>
        [JsonPropertyName("own_grades")]
        public string OwnGrades { get; set; }
    }
}
