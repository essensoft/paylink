using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataDeerInsightQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingDataDeerInsightQueryModel : AlipayObject
    {
        /// <summary>
        /// 洞察名称，只能是数字、英文字母、横线或下划线
        /// </summary>
        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [JsonPropertyName("app")]
        public string App { get; set; }

        /// <summary>
        /// 权限类型
        /// </summary>
        [JsonPropertyName("auth")]
        public string Auth { get; set; }

        /// <summary>
        /// 如果未查询到洞察，是否强制新建一个返回
        /// </summary>
        [JsonPropertyName("force")]
        public bool Force { get; set; }

        /// <summary>
        /// 是否强制更新该洞察为最新版洞察
        /// </summary>
        [JsonPropertyName("force_update")]
        public bool ForceUpdate { get; set; }

        /// <summary>
        /// 业务空间唯一标识
        /// </summary>
        [JsonPropertyName("group_domain")]
        public string GroupDomain { get; set; }

        /// <summary>
        /// 洞察唯一标识
        /// </summary>
        [JsonPropertyName("insight_domain")]
        public string InsightDomain { get; set; }

        /// <summary>
        /// 业务指定的额外参数
        /// </summary>
        [JsonPropertyName("params")]
        public string Params { get; set; }

        /// <summary>
        /// 调用服务的业务系统
        /// </summary>
        [JsonPropertyName("system")]
        public string System { get; set; }
    }
}
