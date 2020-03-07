using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityDataNamelistSendModel Data Structure.
    /// </summary>
    public class AlipaySecurityDataNamelistSendModel : AlipayObject
    {
        /// <summary>
        /// 业务名称,用来区分消息处理类目
        /// </summary>
        [JsonPropertyName("bizname")]
        public string Bizname { get; set; }

        /// <summary>
        /// json格式具体内容.
        /// </summary>
        [JsonPropertyName("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// 对方系统名称,用于追踪消息发送来源系统
        /// </summary>
        [JsonPropertyName("sysname")]
        public string Sysname { get; set; }
    }
}
