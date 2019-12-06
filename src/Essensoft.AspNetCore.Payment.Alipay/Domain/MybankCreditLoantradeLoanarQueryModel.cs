using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeLoanarQueryModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradeLoanarQueryModel : AlipayObject
    {
        /// <summary>
        /// 客户的角色编号
        /// </summary>
        [JsonPropertyName("iproleid")]
        public string Iproleid { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("loanarno")]
        public string Loanarno { get; set; }
    }
}
