using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DishonestyDetailInfo Data Structure.
    /// </summary>
    public class DishonestyDetailInfo : AlipayObject
    {
        /// <summary>
        /// 被执行人行为具体情况
        /// </summary>
        [JsonPropertyName("behavior")]
        public string Behavior { get; set; }

        /// <summary>
        /// 案号
        /// </summary>
        [JsonPropertyName("case_code")]
        public string CaseCode { get; set; }

        /// <summary>
        /// 执行法院
        /// </summary>
        [JsonPropertyName("enforce_court")]
        public string EnforceCourt { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonPropertyName("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 被执行人履行情况
        /// </summary>
        [JsonPropertyName("performance")]
        public string Performance { get; set; }

        /// <summary>
        /// 发布日期
        /// </summary>
        [JsonPropertyName("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 所在区域
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }
    }
}
