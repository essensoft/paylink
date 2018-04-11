using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoAutoinsprodQuoteQueryModel : AlipayObject
    {
        /// <summary>
        /// 询价ID
        /// </summary>
        [JsonProperty("enquiry_biz_id")]
        [XmlElement("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [JsonProperty("quote_biz_id")]
        [XmlElement("quote_biz_id")]
        public string QuoteBizId { get; set; }
    }
}
