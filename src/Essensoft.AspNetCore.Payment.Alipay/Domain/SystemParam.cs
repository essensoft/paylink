using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SystemParam Data Structure.
    /// </summary>
    public class SystemParam : AlipayObject
    {
        /// <summary>
        /// 业务功能类型
        /// </summary>
        [JsonPropertyName("function")]
        public string Function { get; set; }

        /// <summary>
        /// 业务合作伙伴
        /// </summary>
        [JsonPropertyName("partner")]
        public string Partner { get; set; }

        /// <summary>
        /// 系统幂等请求id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
