using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateXuexinIdentityQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateXuexinIdentityQueryModel : AlipayObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型， IDENTITY_CARD("IDENTITY_CARD", "1", "身份证")，PASSPORT("PASSPORT", "A", "护照")，目前只支持身份证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 教育层次 SPECIALTY("专科", "0"), UNDERGRADUATE("本科", "1"), POSTGRADUATE("研究生班", "2"), MASTER("硕士研究生", "3"), DOCTOR("博士研究生", "4"), SECOND_DEGREE("第二学士学位", "5"), HIGH_SCHOOL_TO_UNDERGRADUATE("高升本", "6"), JUNIOR_COLLEGE_TO_UNDERGRADUATE("专升本", "7"), SECOND_UNDERGRADUATE_COURSE("第二本科", "8"), JUNIOR_COLLEGE_VOCATIONAL_COLLEGE("专科(高职)", "9"), SECOND_SPECIALTY("第二专科", "10"), GENERAL_CLASS_OF_NIGHT_UNIVERSITY("夜大电大函大普通班", "11"), UNIVERSITY("大学", "12"), OTHER("*", "13"),
        /// </summary>
        [JsonPropertyName("education_level")]
        public string EducationLevel { get; set; }

        /// <summary>
        /// 入学日期
        /// </summary>
        [JsonPropertyName("enroll_date")]
        public string EnrollDate { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
