using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarCarmodelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarCarmodelQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝车型库车型编号,系统唯一。
        /// </summary>
        [JsonProperty("model_id")]
        [XmlElement("model_id")]
        public string ModelId { get; set; }
    }
}
