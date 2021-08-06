using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntfarmProjectInfo Data Structure.
    /// </summary>
    public class AntfarmProjectInfo : AlipayObject
    {
        /// <summary>
        /// 捐赠项目 id
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 捐赠项目名称
        /// </summary>
        [JsonPropertyName("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 当前项目下标的物列表
        /// </summary>
        [JsonPropertyName("target_list")]
        public List<AntfarmProjectTargetInfo> TargetList { get; set; }
    }
}
