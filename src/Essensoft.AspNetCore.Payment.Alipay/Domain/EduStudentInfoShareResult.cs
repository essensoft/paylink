using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduStudentInfoShareResult Data Structure.
    /// </summary>
    [Serializable]
    public class EduStudentInfoShareResult : AlipayObject
    {
        /// <summary>
        /// 教育分类
        /// </summary>
        [JsonProperty("biz_type")]
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 学生详细信息
        /// </summary>
        [JsonProperty("student_infos")]
        [XmlArray("student_infos")]
        [XmlArrayItem("student_info")]
        public List<StudentInfo> StudentInfos { get; set; }

        /// <summary>
        /// 用户的userid
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
