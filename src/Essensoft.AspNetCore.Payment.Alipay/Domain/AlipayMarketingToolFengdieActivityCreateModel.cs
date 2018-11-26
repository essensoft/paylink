using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieActivityCreateModel : AlipayObject
    {
        /// <summary>
        /// H5应用初始化数据
        /// </summary>
        [JsonProperty("activity")]
        [XmlElement("activity")]
        public FengdieActivityCreateData Activity { get; set; }

        /// <summary>
        /// 凤蝶模板包唯一id，从alipay.marketing.tool.fengdie.template.query接口中获取
        /// </summary>
        [JsonProperty("template_id")]
        [XmlElement("template_id")]
        public long TemplateId { get; set; }
    }
}
