using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExerciseItemOpenModelSecond Data Structure.
    /// </summary>
    [Serializable]
    public class ExerciseItemOpenModelSecond : AlipayObject
    {
        /// <summary>
        /// 健身项目简介
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 健身项目在外部(ISV)系统中的ID
        /// </summary>
        [JsonProperty("external_item_id")]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 必填项目类型码。由ISV保证唯一。
        /// </summary>
        [JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 三级健身项目列表
        /// </summary>
        [JsonProperty("item_list")]
        public List<ExerciseItemOpenModelThird> ItemList { get; set; }

        /// <summary>
        /// 计量信息列表
        /// </summary>
        [JsonProperty("meter_list")]
        public MeterOpenModel MeterList { get; set; }

        /// <summary>
        /// 二级健身项目名称。
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
