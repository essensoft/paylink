using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExerciseItem Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseItem : AlipayObject
    {
        /// <summary>
        /// 项目描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 外部项目ID
        /// </summary>
        [JsonProperty("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 项目类型码
        /// </summary>
        [JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 健身项目名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父项目类型码
        /// </summary>
        [JsonProperty("parent_item_code")]
        public string ParentItemCode { get; set; }
    }
}
