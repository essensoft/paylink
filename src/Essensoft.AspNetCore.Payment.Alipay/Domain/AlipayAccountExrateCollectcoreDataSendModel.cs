using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExrateCollectcoreDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountExrateCollectcoreDataSendModel : AlipayObject
    {
        /// <summary>
        /// 上数提交数据内容
        /// </summary>
        [JsonProperty("content")]
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
