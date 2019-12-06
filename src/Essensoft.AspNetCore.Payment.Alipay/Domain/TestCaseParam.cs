using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TestCaseParam Data Structure.
    /// </summary>
    public class TestCaseParam : AlipayObject
    {
        /// <summary>
        /// 测试用例ID或者编码
        /// </summary>
        [JsonPropertyName("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// 测试用例类型
        /// </summary>
        [JsonPropertyName("case_type")]
        public string CaseType { get; set; }

        /// <summary>
        /// 用例集ID
        /// </summary>
        [JsonPropertyName("test_suite_id")]
        public string TestSuiteId { get; set; }

        /// <summary>
        /// 用例集名称
        /// </summary>
        [JsonPropertyName("test_suite_name")]
        public string TestSuiteName { get; set; }
    }
}
