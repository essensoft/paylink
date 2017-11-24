using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeLoanarQueryModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradeLoanarQueryModel : AlipayObject
    {
        /// <summary>
        /// 客户的角色编号
        /// </summary>
        [JsonProperty("iproleid")]
        public string Iproleid { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonProperty("loanarno")]
        public string Loanarno { get; set; }
    }
}
