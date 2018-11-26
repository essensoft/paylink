using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataDeerInsightQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataDeerInsightQueryModel : AlipayObject
    {
        /// <summary>
        /// 洞察名称，只能是数字、英文字母、横线或下划线
        /// </summary>
        [JsonProperty("alias")]
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [JsonProperty("app")]
        [XmlElement("app")]
        public string App { get; set; }

        /// <summary>
        /// 权限类型
        /// </summary>
        [JsonProperty("auth")]
        [XmlElement("auth")]
        public string Auth { get; set; }

        /// <summary>
        /// 如果未查询到洞察，是否强制新建一个返回
        /// </summary>
        [JsonProperty("force")]
        [XmlElement("force")]
        public bool Force { get; set; }

        /// <summary>
        /// 是否强制更新该洞察为最新版洞察
        /// </summary>
        [JsonProperty("force_update")]
        [XmlElement("force_update")]
        public bool ForceUpdate { get; set; }

        /// <summary>
        /// 业务空间唯一标识
        /// </summary>
        [JsonProperty("group_domain")]
        [XmlElement("group_domain")]
        public string GroupDomain { get; set; }

        /// <summary>
        /// 洞察唯一标识
        /// </summary>
        [JsonProperty("insight_domain")]
        [XmlElement("insight_domain")]
        public string InsightDomain { get; set; }

        /// <summary>
        /// 业务指定的额外参数
        /// </summary>
        [JsonProperty("params")]
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 调用服务的业务系统
        /// </summary>
        [JsonProperty("system")]
        [XmlElement("system")]
        public string System { get; set; }
    }
}
