using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExercisePlanOpenModel Data Structure.
    /// </summary>
    public class ExercisePlanOpenModel : AlipayObject
    {
        /// <summary>
        /// 运动计划类型。枚举：运动项目(ITEM),或课程(COURSE)
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 课程列表。当biz_type=COURSE时必填
        /// </summary>
        [JsonPropertyName("course_list")]
        public List<ExerciseCourseOpenModel> CourseList { get; set; }

        /// <summary>
        /// 一级健身项目列表。当biz_type=ITEM时必填
        /// </summary>
        [JsonPropertyName("item_list")]
        public List<ExerciseItemOpenModel> ItemList { get; set; }

        /// <summary>
        /// 时间维度类型。枚举：DAY("日"),WEEK("周"),MONTH("月"),LIFE("终生")
        /// </summary>
        [JsonPropertyName("time_dimension_type")]
        public string TimeDimensionType { get; set; }

        /// <summary>
        /// 维度所所对应的值。用英文逗号,分割。DAY时留空，WEEK时取值范围1-7，MONTH时取值范围1-31，LIFE时为yyyy-MM-dd格式的日期
        /// </summary>
        [JsonPropertyName("values")]
        public string Values { get; set; }
    }
}
