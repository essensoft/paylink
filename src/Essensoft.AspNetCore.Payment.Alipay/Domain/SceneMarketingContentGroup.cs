using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneMarketingContentGroup Data Structure.
    /// </summary>
    public class SceneMarketingContentGroup : AlipayObject
    {
        /// <summary>
        /// 营销内容列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<SceneMarketingContent> DataList { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 简要描述
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }
    }
}
