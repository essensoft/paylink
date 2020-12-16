using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TuitionISVStudentInfoDTO Data Structure.
    /// </summary>
    public class TuitionISVStudentInfoDTO : AlipayObject
    {
        /// <summary>
        /// 电子邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 入学时间
        /// </summary>
        [JsonPropertyName("entrance_date")]
        public string EntranceDate { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 学生身份证号
        /// </summary>
        [JsonPropertyName("identity_card_number")]
        public string IdentityCardNumber { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [JsonPropertyName("student_name")]
        public string StudentName { get; set; }

        /// <summary>
        /// 20100120
        /// </summary>
        [JsonPropertyName("student_number")]
        public string StudentNumber { get; set; }

        /// <summary>
        /// 学生手机号
        /// </summary>
        [JsonPropertyName("student_phone_number")]
        public string StudentPhoneNumber { get; set; }
    }
}
