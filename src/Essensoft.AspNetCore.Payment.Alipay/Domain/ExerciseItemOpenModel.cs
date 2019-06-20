using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExerciseItemOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseItemOpenModel : AlipayObject
    {
        /// <summary>
        /// 健身项目描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 健身项目在外部系统中的ID
        /// </summary>
        [JsonProperty("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 项目类型码:一级只有两种 有氧运动(CARDIO)、重力锻炼(MUSCLE)
        /// </summary>
        [JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 子健身项目列表。一般重力训练锻炼的肌肉群，有氧运动对应是运动类型
        /// </summary>
        [JsonProperty("item_list")]
        public ExerciseItemOpenModelSecond ItemList { get; set; }

        /// <summary>
        /// 健身项目名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
