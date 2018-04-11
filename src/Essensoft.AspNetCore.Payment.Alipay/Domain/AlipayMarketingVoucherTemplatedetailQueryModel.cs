using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherTemplatedetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherTemplatedetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
