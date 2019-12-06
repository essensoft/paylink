using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

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
        [JsonPropertyName("app_ids")]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// 模板使用信息
        /// </summary>
        [JsonPropertyName("template_usage_info_list")]
        public List<TemplateUsageInfo> TemplateUsageInfoList { get; set; }
    }
}
