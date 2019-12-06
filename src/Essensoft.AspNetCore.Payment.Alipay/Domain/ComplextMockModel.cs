using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ComplextMockModel Data Structure.
    /// </summary>
    public class ComplextMockModel : AlipayObject
    {
        /// <summary>
        /// biz_model
        /// </summary>
        [JsonPropertyName("biz_model")]
        public SimpleMockModel BizModel { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [JsonPropertyName("biz_num")]
        public long BizNum { get; set; }

        /// <summary>
        /// 208xxx
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }
    }
}
