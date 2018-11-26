using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoEduKtStudentQueryResponse.
    /// </summary>
    public class AlipayEcoEduKtStudentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 学生姓名
        /// </summary>
        [JsonProperty("child_name")]
        [XmlElement("child_name")]
        public string ChildName { get; set; }

        /// <summary>
        /// 班级名字
        /// </summary>
        [JsonProperty("class_name")]
        [XmlElement("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonProperty("school_name")]
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学生编号
        /// </summary>
        [JsonProperty("student_code")]
        [XmlElement("student_code")]
        public string StudentCode { get; set; }

        /// <summary>
        /// 学生身份证
        /// </summary>
        [JsonProperty("student_identify")]
        [XmlElement("student_identify")]
        public string StudentIdentify { get; set; }

        /// <summary>
        /// 家长信息
        /// </summary>
        [JsonProperty("users")]
        [XmlArray("users")]
        [XmlArrayItem("user_details")]
        public List<UserDetails> Users { get; set; }
    }
}
