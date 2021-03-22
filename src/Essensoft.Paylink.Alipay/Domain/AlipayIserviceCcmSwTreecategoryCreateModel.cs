using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwTreecategoryCreateModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmSwTreecategoryCreateModel : AlipayObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 父节点ID
        /// </summary>
        [JsonPropertyName("father_id")]
        public long FatherId { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签。KNOWLEDGE（知识库）；PLATFORM（公有云工作台）；HELP（公有云帮助中心）
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
    }
}
