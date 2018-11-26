using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BillInferenceResult Data Structure.
    /// </summary>
    [Serializable]
    public class BillInferenceResult : AlipayObject
    {
        /// <summary>
        /// 角度
        /// </summary>
        [JsonProperty("angle")]
        [XmlElement("angle")]
        public long Angle { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        [JsonProperty("bill_score")]
        [XmlElement("bill_score")]
        public long BillScore { get; set; }

        /// <summary>
        /// 算法版本
        /// </summary>
        [JsonProperty("bill_version")]
        [XmlElement("bill_version")]
        public string BillVersion { get; set; }

        /// <summary>
        /// 发票金额
        /// </summary>
        [JsonProperty("capital_sum")]
        [XmlArray("capital_sum")]
        [XmlArrayItem("string")]
        public List<string> CapitalSum { get; set; }

        /// <summary>
        /// 发票时间
        /// </summary>
        [JsonProperty("date")]
        [XmlArray("date")]
        [XmlArrayItem("string")]
        public List<string> Date { get; set; }

        /// <summary>
        /// 发票报销人
        /// </summary>
        [JsonProperty("name")]
        [XmlArray("name")]
        [XmlArrayItem("string")]
        public List<string> Name { get; set; }

        /// <summary>
        /// 发票号
        /// </summary>
        [JsonProperty("no")]
        [XmlArray("no")]
        [XmlArrayItem("string")]
        public List<string> No { get; set; }

        /// <summary>
        /// 分辨率
        /// </summary>
        [JsonProperty("rotate_shape")]
        [XmlArray("rotate_shape")]
        [XmlArrayItem("string")]
        public List<string> RotateShape { get; set; }

        /// <summary>
        /// 发票标题
        /// </summary>
        [JsonProperty("title")]
        [XmlArray("title")]
        [XmlArrayItem("string")]
        public List<string> Title { get; set; }
    }
}
