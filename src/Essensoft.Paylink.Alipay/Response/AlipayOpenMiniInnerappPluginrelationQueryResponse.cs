using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerappPluginrelationQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerappPluginrelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page")]
        public long Page { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 插件关联关系信息
        /// </summary>
        [JsonPropertyName("plugin_relation_info_list")]
        public List<PluginUseRelationInfo> PluginRelationInfoList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
