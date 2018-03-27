using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 开发者开发上传的H5模板列表
        /// </summary>
        [JsonProperty("template")]
        public List<FengdieTemplate> Template { get; set; }
    }
}
