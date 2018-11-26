using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 模板详情列表
        /// </summary>
        [JsonProperty("data")]
        [XmlElement("data")]
        public FengdieTemplateListRespModel Data { get; set; }
    }
}
