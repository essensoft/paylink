using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExerciseItemOpenModelThird Data Structure.
    /// </summary>
    public class ExerciseItemOpenModelThird : AlipayObject
    {
        /// <summary>
        /// 健身项目简介
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 健身项目在外部(ISV)系统中的ID
        /// </summary>
        [JsonPropertyName("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 必填项目类型码:由ISV保证唯一
        /// </summary>
        [JsonPropertyName("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 计量信息列表
        /// </summary>
        [JsonPropertyName("meter_list")]
        public MeterOpenModel MeterList { get; set; }

        /// <summary>
        /// 三级健身项目名称
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
