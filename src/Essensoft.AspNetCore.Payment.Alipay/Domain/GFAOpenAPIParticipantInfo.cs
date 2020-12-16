using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GFAOpenAPIParticipantInfo Data Structure.
    /// </summary>
    public class GFAOpenAPIParticipantInfo : AlipayObject
    {
        /// <summary>
        /// 参与者账户
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 参与者账户类型
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 参与者机构Id
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 参与者角色id（如支付宝中的uid）
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 参与者扩展信息。Map<String, String> 类型 JSON 字符串
        /// </summary>
        [JsonPropertyName("properties")]
        public string Properties { get; set; }
    }
}
