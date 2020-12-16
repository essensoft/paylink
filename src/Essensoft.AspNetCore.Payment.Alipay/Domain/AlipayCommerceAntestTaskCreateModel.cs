using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAntestTaskCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceAntestTaskCreateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝版本
        /// </summary>
        [JsonPropertyName("alipay_version")]
        public string AlipayVersion { get; set; }

        /// <summary>
        /// appId
        /// </summary>
        [JsonPropertyName("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 用例列表
        /// </summary>
        [JsonPropertyName("case_list")]
        public string CaseList { get; set; }

        /// <summary>
        /// 设备策略
        /// </summary>
        [JsonPropertyName("device_strategy")]
        public string DeviceStrategy { get; set; }

        /// <summary>
        /// 2000002
        /// </summary>
        [JsonPropertyName("mock_group_id")]
        public long MockGroupId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 测试策略
        /// </summary>
        [JsonPropertyName("test_strategy")]
        public string TestStrategy { get; set; }
    }
}
