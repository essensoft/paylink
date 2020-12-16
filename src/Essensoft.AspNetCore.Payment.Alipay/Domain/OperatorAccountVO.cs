using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OperatorAccountVO Data Structure.
    /// </summary>
    public class OperatorAccountVO : AlipayObject
    {
        /// <summary>
        /// 关联账号ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 关联账号类型。枚举值参考OperatorRelAccountTypeEnum account_type=01，则account_id为支付宝userId account_type=02，则account_id为钉钉账号id account_type=03，则account_id为支付宝oid
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }
    }
}
