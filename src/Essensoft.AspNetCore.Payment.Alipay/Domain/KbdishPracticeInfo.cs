using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishPracticeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishPracticeInfo : AlipayObject
    {
        /// <summary>
        /// 口碑的菜品id
        /// </summary>
        [JsonProperty("dish_id")]
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 加价类型  add:直接加 multiply:乘以系数
        /// </summary>
        [JsonProperty("increase_mode")]
        [XmlElement("increase_mode")]
        public string IncreaseMode { get; set; }

        /// <summary>
        /// 加价金额
        /// </summary>
        [JsonProperty("increase_price")]
        [XmlElement("increase_price")]
        public string IncreasePrice { get; set; }

        /// <summary>
        /// 做法名称
        /// </summary>
        [JsonProperty("practice_name")]
        [XmlElement("practice_name")]
        public string PracticeName { get; set; }
    }
}
