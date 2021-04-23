using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateStudentIdentityVerifyResponse.
    /// </summary>
    public class AlipayCommerceEducateStudentIdentityVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 签名
        /// </summary>
        [JsonPropertyName("biz_sign")]
        public string BizSign { get; set; }

        /// <summary>
        /// 是否是学生，1是；0否
        /// </summary>
        [JsonPropertyName("college_online_tag")]
        public string CollegeOnlineTag { get; set; }

        /// <summary>
        /// 学历，枚举类型：专科0，本科1，研究生2，博士3，本硕连读4，硕博连读5，本硕博连读6
        /// </summary>
        [JsonPropertyName("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 入学时间，格式yyyy-mm-dd
        /// </summary>
        [JsonPropertyName("enroll_date")]
        public string EnrollDate { get; set; }

        /// <summary>
        /// 审核状态，0-审核中，2-审核不通过，3-审核通过，5-无数据
        /// </summary>
        [JsonPropertyName("examine_status")]
        public string ExamineStatus { get; set; }

        /// <summary>
        /// 会员状态，1 校园会员；0 新用户
        /// </summary>
        [JsonPropertyName("member_ship_status")]
        public string MemberShipStatus { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [JsonPropertyName("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonPropertyName("time_stamp")]
        public string TimeStamp { get; set; }

        /// <summary>
        /// 身份类型，1-学生；2-教师；3-校友；4-考生；5-家长
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
