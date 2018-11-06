using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OtherAmountInfos Data Structure.
    /// </summary>
    [Serializable]
    public class OtherAmountInfos : AlipayObject
    {
        /// <summary>
        /// 费用金额
        /// </summary>
        [JsonProperty("price")]
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 可枚举的类型。  SERVICE_FEE：服务费；  TABLE_FEE：餐台费；  OTHER：其他费用
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
