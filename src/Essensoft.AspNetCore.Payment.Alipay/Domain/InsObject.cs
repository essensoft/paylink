using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsObject Data Structure.
    /// </summary>
    [Serializable]
    public class InsObject : AlipayObject
    {
        /// <summary>
        /// 标的物的标识id
        /// </summary>
        [JsonProperty("insured_object_id")]
        [XmlElement("insured_object_id")]
        public string InsuredObjectId { get; set; }

        /// <summary>
        /// 标的信息;标准json 格式
        /// </summary>
        [JsonProperty("insured_object_info")]
        [XmlElement("insured_object_info")]
        public string InsuredObjectInfo { get; set; }

        /// <summary>
        /// 标的类型;0:财产所在地;1:其它;2:车;3:资金债务;4:电商订单
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
