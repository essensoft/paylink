using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecResultInfo : AlipayObject
    {
        /// <summary>
        /// 错误码  NO_REC_ITEMS 无推荐服务  NO_ENOUGH_ITEMS 推荐数量不合法
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 推荐ITEM
        /// </summary>
        [JsonProperty("items")]
        [XmlArray("items")]
        [XmlArrayItem("rec_item_info")]
        public List<RecItemInfo> Items { get; set; }

        /// <summary>
        /// 错误消息，如果成功则为空
        /// </summary>
        [JsonProperty("msg")]
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 推荐结果
        /// </summary>
        [JsonProperty("position_id")]
        [XmlElement("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("success")]
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
