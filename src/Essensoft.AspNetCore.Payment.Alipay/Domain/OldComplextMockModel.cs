using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OldComplextMockModel Data Structure.
    /// </summary>
    public class OldComplextMockModel : AlipayObject
    {
        /// <summary>
        /// biz_num
        /// </summary>
        [JsonPropertyName("biz_num")]
        public long BizNum { get; set; }

        /// <summary>
        /// biz_type
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 简单model
        /// </summary>
        [JsonPropertyName("simple_mock_model")]
        public SimpleMockModel SimpleMockModel { get; set; }
    }
}
