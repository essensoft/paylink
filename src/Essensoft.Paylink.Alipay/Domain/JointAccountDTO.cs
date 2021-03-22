using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// JointAccountDTO Data Structure.
    /// </summary>
    public class JointAccountDTO : AlipayObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 共同账户账本名称
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账本创建人会员号
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
