using Newtonsoft.Json;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitleDynamicGetResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitleDynamicGetResponse : AlipayResponse
    {
        /// <summary>
        /// 发票抬头
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public InvoiceTitleModel Title { get; set; }
    }
}
