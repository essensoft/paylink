using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankFinanceYulibaoAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankFinanceYulibaoAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金代码，必填。目前默认填001529，代表余利宝
        /// </summary>
        [JsonProperty("fund_code")]
        [XmlElement("fund_code")]
        public string FundCode { get; set; }
    }
}
