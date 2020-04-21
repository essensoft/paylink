using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BccSubjectDetail Data Structure.
    /// </summary>
    public class BccSubjectDetail : AlipayObject
    {
        /// <summary>
        /// 标的完成值
        /// </summary>
        [JsonPropertyName("completions")]
        public string Completions { get; set; }

        /// <summary>
        /// 当前值
        /// </summary>
        [JsonPropertyName("current_value")]
        public string CurrentValue { get; set; }

        /// <summary>
        /// 该标的对应的事项
        /// </summary>
        [JsonPropertyName("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 标的id
        /// </summary>
        [JsonPropertyName("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 标的类型
        /// </summary>
        [JsonPropertyName("subject_type")]
        public string SubjectType { get; set; }
    }
}
