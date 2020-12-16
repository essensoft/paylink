using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExternalContact Data Structure.
    /// </summary>
    public class ExternalContact : AlipayObject
    {
        /// <summary>
        /// 邮箱地址
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 支付宝侧外部联系人的主键
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 工作时间段/工作性质等
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
