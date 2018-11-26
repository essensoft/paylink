using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenBatch Data Structure.
    /// </summary>
    [Serializable]
    public class OpenBatch : AlipayObject
    {
        /// <summary>
        /// 批次id
        /// </summary>
        [JsonProperty("batch_id")]
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 批次状态  0，未检测  1，检测中  2，未通过  3，已通过
        /// </summary>
        [JsonProperty("batch_status")]
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 单品数
        /// </summary>
        [JsonProperty("item_num")]
        [XmlElement("item_num")]
        public string ItemNum { get; set; }
    }
}
