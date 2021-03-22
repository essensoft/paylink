using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoDoctemplateSettingurlQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoDoctemplateSettingurlQueryModel : AlipayObject
    {
        /// <summary>
        /// 合同模板id。通过<a href ="https://opendocs.alipay.com/apis/api_50/alipay.eco.doc.template.create">创建合同模版</a>（alipay.eco.doc.template.create）接口获取。
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
