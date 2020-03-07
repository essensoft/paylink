using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberCreateModel Data Structure.
    /// </summary>
    public class KoubeiServindustryExerciseMemberCreateModel : AlipayObject
    {
        /// <summary>
        /// 外部会籍id
        /// </summary>
        [JsonPropertyName("external_member_id")]
        public string ExternalMemberId { get; set; }

        /// <summary>
        /// 健身用户id
        /// </summary>
        [JsonPropertyName("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 会籍的到期时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 会籍的开始时间
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 会籍级别
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 会籍名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 外部请求ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 适用的口碑门店id或商户列表
        /// </summary>
        [JsonPropertyName("subject_id_list")]
        public List<string> SubjectIdList { get; set; }

        /// <summary>
        /// 关联类型
        /// </summary>
        [JsonPropertyName("subject_type")]
        public string SubjectType { get; set; }

        /// <summary>
        /// 口碑的用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
