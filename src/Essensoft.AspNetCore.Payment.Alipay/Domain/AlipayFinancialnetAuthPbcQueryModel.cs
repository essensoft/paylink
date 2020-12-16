using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthPbcQueryModel Data Structure.
    /// </summary>
    public class AlipayFinancialnetAuthPbcQueryModel : AlipayObject
    {
        /// <summary>
        /// 联行号
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [JsonPropertyName("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }
    }
}
