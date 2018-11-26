using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduKtParentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduKtParentQueryModel : AlipayObject
    {
        /// <summary>
        /// 孩子或学生姓名
        /// </summary>
        [JsonProperty("child_name")]
        [XmlElement("child_name")]
        public string ChildName { get; set; }

        /// <summary>
        /// Isv的支付宝pid
        /// </summary>
        [JsonProperty("partner_id")]
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 学校编码，录入学校接口返回的school_no参数
        /// </summary>
        [JsonProperty("school_no")]
        [XmlElement("school_no")]
        public string SchoolNo { get; set; }

        /// <summary>
        /// 学校支付宝pid
        /// </summary>
        [JsonProperty("school_pid")]
        [XmlElement("school_pid")]
        public string SchoolPid { get; set; }

        /// <summary>
        /// 学生的学号，一个学校的学号必须是唯一。结果返回用户是否通过此学号添加此学生的缴费账户。user_mobile、student_code 、student_identify 必须并且只能填一项。
        /// </summary>
        [JsonProperty("student_code")]
        [XmlElement("student_code")]
        public string StudentCode { get; set; }

        /// <summary>
        /// 学生的身份证号，使用身份证规则验证。结果返回用户是否通过此身份证号添加此学生的缴费账户。user_mobile、student_code 、student_identify 必须并且只能填一项。
        /// </summary>
        [JsonProperty("student_identify")]
        [XmlElement("student_identify")]
        public string StudentIdentify { get; set; }

        /// <summary>
        /// 用户手机号，发账单时填写users数组中的一个手机号。结果返回用户是否通过此手机号添加此学生的缴费账户。user_mobile、student_code 、student_identify 必须并且只能填一项。
        /// </summary>
        [JsonProperty("user_mobile")]
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }
    }
}
