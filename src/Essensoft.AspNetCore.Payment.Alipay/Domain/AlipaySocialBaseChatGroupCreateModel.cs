using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGroupCreateModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseChatGroupCreateModel : AlipayObject
    {
        /// <summary>
        /// 请求唯一id（用户id+时间戳+随机数），防止重复建群
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }
    }
}
