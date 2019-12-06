using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SmartCityCommodityInfo Data Structure.
    /// </summary>
    public class SmartCityCommodityInfo : AlipayObject
    {
        /// <summary>
        /// 服务归属
        /// </summary>
        [JsonPropertyName("affiliation")]
        public string Affiliation { get; set; }

        /// <summary>
        /// 授权文件
        /// </summary>
        [JsonPropertyName("auth_file")]
        public string AuthFile { get; set; }

        /// <summary>
        /// 测试验收说明
        /// </summary>
        [JsonPropertyName("test_detail")]
        public string TestDetail { get; set; }

        /// <summary>
        /// 测试报表
        /// </summary>
        [JsonPropertyName("test_report")]
        public string TestReport { get; set; }

        /// <summary>
        /// 用户指南
        /// </summary>
        [JsonPropertyName("user_guide")]
        public string UserGuide { get; set; }
    }
}
