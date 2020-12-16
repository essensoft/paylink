using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LargeInfiniteCardInfo Data Structure.
    /// </summary>
    public class LargeInfiniteCardInfo : AlipayObject
    {
        /// <summary>
        /// 无限付产品转账的转入卡账户名称，支付宝分配。
        /// </summary>
        [JsonPropertyName("bank_account_name")]
        public string BankAccountName { get; set; }

        /// <summary>
        /// 无限付产品转账的转入卡账号，支付宝分配。
        /// </summary>
        [JsonPropertyName("bank_account_no")]
        public string BankAccountNo { get; set; }

        /// <summary>
        /// 无限付产品转账的转入行银行支行名称
        /// </summary>
        [JsonPropertyName("bank_branch")]
        public string BankBranch { get; set; }

        /// <summary>
        /// 无限付产品转账的转入行银行联行号
        /// </summary>
        [JsonPropertyName("bank_branch_code")]
        public string BankBranchCode { get; set; }

        /// <summary>
        /// 无限付产品转账的转入行银行名称
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 无限付产品转账的转入行银行开户地
        /// </summary>
        [JsonPropertyName("open_place")]
        public string OpenPlace { get; set; }
    }
}
