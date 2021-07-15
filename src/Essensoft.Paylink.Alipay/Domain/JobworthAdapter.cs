using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// JobworthAdapter Data Structure.
    /// </summary>
    public class JobworthAdapter : AlipayObject
    {
        /// <summary>
        /// 两个数字 使用英文逗号隔开，-1代表没要求。eg:18,35表示18岁到35岁，-1,40表示40岁以下
        /// </summary>
        [JsonPropertyName("age")]
        public string Age { get; set; }

        /// <summary>
        /// cityCode 要求使用的高德cityCode
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 学历，可以用以下字段IGHSCHOOL_AND_BELOW（高中及以下），POLYTECHNIC（中专），COLLEGE（大专），BACHELOR（本科），MASTER（硕士），DOCTOR_AND_ABOVE（博士及以上）
        /// </summary>
        [JsonPropertyName("edu_level")]
        public string EduLevel { get; set; }

        /// <summary>
        /// 性别，男或者女， 要求这2个汉字二选一，如果没有要求，这个字段可以不填写
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 推荐次数
        /// </summary>
        [JsonPropertyName("recommend")]
        public string Recommend { get; set; }

        /// <summary>
        /// 要求的技能证书
        /// </summary>
        [JsonPropertyName("skill_certificate")]
        public string SkillCertificate { get; set; }
    }
}
