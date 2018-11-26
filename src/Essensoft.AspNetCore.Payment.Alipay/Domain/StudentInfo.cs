using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StudentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StudentInfo : AlipayObject
    {
        /// <summary>
        /// 学校所在行政区域编码
        /// </summary>
        [JsonProperty("city_no")]
        [XmlElement("city_no")]
        public string CityNo { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        [JsonProperty("class_name")]
        [XmlElement("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonProperty("college_name")]
        [XmlElement("college_name")]
        public string CollegeName { get; set; }

        /// <summary>
        /// 学校机构编号
        /// </summary>
        [JsonProperty("college_no")]
        [XmlElement("college_no")]
        public string CollegeNo { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        [JsonProperty("degree")]
        [XmlElement("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 院系
        /// </summary>
        [JsonProperty("departments")]
        [XmlElement("departments")]
        public string Departments { get; set; }

        /// <summary>
        /// 入校时间
        /// </summary>
        [JsonProperty("gmt_enrollment")]
        [XmlElement("gmt_enrollment")]
        public string GmtEnrollment { get; set; }

        /// <summary>
        /// 毕业时间
        /// </summary>
        [JsonProperty("gmt_graduation")]
        [XmlElement("gmt_graduation")]
        public string GmtGraduation { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        [JsonProperty("major")]
        [XmlElement("major")]
        public string Major { get; set; }

        /// <summary>
        /// 学生证号
        /// </summary>
        [JsonProperty("student_id")]
        [XmlElement("student_id")]
        public string StudentId { get; set; }
    }
}
