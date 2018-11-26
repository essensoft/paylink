using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceFundFundquotationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceFundFundquotationQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金编号：基金产品编号
        /// </summary>
        [JsonProperty("fund_code")]
        [XmlElement("fund_code")]
        public string FundCode { get; set; }
    }
}
