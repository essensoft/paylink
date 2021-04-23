using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BankAccount Data Structure.
    /// </summary>
    public class BankAccount : AlipayObject
    {
        /// <summary>
        /// 收款账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户类型
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 银行支行联行号
        /// </summary>
        [JsonPropertyName("bank_branch_code")]
        public string BankBranchCode { get; set; }

        /// <summary>
        /// 银行支行
        /// </summary>
        [JsonPropertyName("bank_branch_name")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 开户行银行所在市
        /// </summary>
        [JsonPropertyName("bank_city_name")]
        public string BankCityName { get; set; }

        /// <summary>
        /// 开户行银行编码缩写
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 开户行银行名称
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 开户行银行所在省
        /// </summary>
        [JsonPropertyName("bank_prov_name")]
        public string BankProvName { get; set; }

        /// <summary>
        /// 开户人证件号码
        /// </summary>
        [JsonPropertyName("holder_cert_no")]
        public string HolderCertNo { get; set; }

        /// <summary>
        /// 开户人名称
        /// </summary>
        [JsonPropertyName("holder_name")]
        public string HolderName { get; set; }
    }
}
