using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduCampusJobdeliverModifyModel Data Structure.
    /// </summary>
    public class AlipayEcoEduCampusJobdeliverModifyModel : AlipayObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 补充文案
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 备用字段
        /// </summary>
        [JsonPropertyName("content_var")]
        public string ContentVar { get; set; }

        /// <summary>
        /// 面试地点
        /// </summary>
        [JsonPropertyName("interview_location")]
        public string InterviewLocation { get; set; }

        /// <summary>
        /// 面试时间(毫秒)
        /// </summary>
        [JsonPropertyName("interview_time")]
        public string InterviewTime { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 职位来源方编码
        /// </summary>
        [JsonPropertyName("source_code")]
        public string SourceCode { get; set; }

        /// <summary>
        /// 职位来源方id
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 投递状态: 4被查看;5待处理;6邀面试;7已拒绝;8已录用;9已结束
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }

        /// <summary>
        /// 状态更新时间(毫秒)
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; }
    }
}
