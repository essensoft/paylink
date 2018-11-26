using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RechargeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RechargeDetail : AlipayObject
    {
        /// <summary>
        /// 真实资金，单位元
        /// </summary>
        [JsonProperty("amount")]
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 面额，单位元
        /// </summary>
        [JsonProperty("assetamount")]
        [XmlElement("assetamount")]
        public string Assetamount { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        [JsonProperty("orderno")]
        [XmlElement("orderno")]
        public string Orderno { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonProperty("outorderno")]
        [XmlElement("outorderno")]
        public string Outorderno { get; set; }
    }
}
