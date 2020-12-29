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

        /// <summary>
        /// 用于场景角色的查询，默认不填 扫码付业务填 1
        /// </summary>
        [JsonPropertyName("roletype")]
        public string Roletype { get; set; }
    }
}
