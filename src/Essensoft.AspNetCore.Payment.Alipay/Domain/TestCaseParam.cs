using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TestCaseParam Data Structure.
    /// </summary>
    [Serializable]
    public class TestCaseParam : AlipayObject
    {
        /// <summary>
        /// 测试用例ID或者编码
        /// </summary>
        [JsonProperty("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// 测试用例类型
        /// </summary>
        [JsonProperty("case_type")]
        public string CaseType { get; set; }

        /// <summary>
        /// 用例集ID
        /// </summary>
        [JsonProperty("test_suite_id")]
        public string TestSuiteId { get; set; }

        /// <summary>
        /// 用例集名称
        /// </summary>
        [JsonProperty("test_suite_name")]
        public string TestSuiteName { get; set; }
    }
}
