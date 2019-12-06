using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExerciseItem Data Structure.
    /// </summary>
    public class ExerciseItem : AlipayObject
    {
        /// <summary>
        /// 项目描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 外部项目ID
        /// </summary>
        [JsonPropertyName("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 项目类型码
        /// </summary>
        [JsonPropertyName("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 健身项目名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父项目类型码
        /// </summary>
        [JsonPropertyName("parent_item_code")]
        public string ParentItemCode { get; set; }
    }
}
