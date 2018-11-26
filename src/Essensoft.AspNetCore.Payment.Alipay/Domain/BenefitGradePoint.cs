using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BenefitGradePoint Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitGradePoint : AlipayObject
    {
        /// <summary>
        /// 蚂蚁会员权益配置的ID
        /// </summary>
        [JsonProperty("benefit_id")]
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 蚂蚁会员权益配置在各个用户等级下的折扣积分
        /// </summary>
        [JsonProperty("grade_points")]
        [XmlArray("grade_points")]
        [XmlArrayItem("grade_discount_point")]
        public List<GradeDiscountPoint> GradePoints { get; set; }

        /// <summary>
        /// 蚂蚁会员权益配置的原始积分
        /// </summary>
        [JsonProperty("original_point")]
        [XmlElement("original_point")]
        public string OriginalPoint { get; set; }

        /// <summary>
        /// 蚂蚁会员权益的专享等级列表
        /// </summary>
        [JsonProperty("own_grades")]
        [XmlElement("own_grades")]
        public string OwnGrades { get; set; }
    }
}
