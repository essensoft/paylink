using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeUnionbankQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeUnionbankQueryModel : AlipayObject
    {
        /// <summary>
        /// 银联编号
        /// </summary>
        [JsonProperty("bank_code")]
        [XmlElement("bank_code")]
        public string BankCode { get; set; }
    }
}
