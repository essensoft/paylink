using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniTemplateUsageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTemplateUsageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序appId列表
        /// </summary>
        [JsonProperty("app_ids")]
        [XmlArray("app_ids")]
        [XmlArrayItem("string")]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// 模板使用信息
        /// </summary>
        [JsonProperty("template_usage_info_list")]
        [XmlArray("template_usage_info_list")]
        [XmlArrayItem("template_usage_info")]
        public List<TemplateUsageInfo> TemplateUsageInfoList { get; set; }
    }
}
