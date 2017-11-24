using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// OldComplextMockModel Data Structure.
    /// </summary>
    public class OldComplextMockModel : AlipayObject
    {
        /// <summary>
        /// biz_num
        /// </summary>
        [JsonProperty("biz_num")]
        public long BizNum { get; set; }

        /// <summary>
        /// biz_type
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 简单model
        /// </summary>
        [JsonProperty("simple_mock_model")]
        public SimpleMockModel SimpleMockModel { get; set; }
    }
}
