using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TestCaseDomain Data Structure.
    /// </summary>
    public class TestCaseDomain : AlipayObject
    {
        /// <summary>
        /// ISV的测试节点
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 测试用例id
        /// </summary>
        [JsonPropertyName("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// 测试集id
        /// </summary>
        [JsonPropertyName("collection_id")]
        public string CollectionId { get; set; }

        /// <summary>
        /// 测试用例描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 测试用例拓展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 测试用例优先级
        /// </summary>
        [JsonPropertyName("priority")]
        public string Priority { get; set; }
    }
}
