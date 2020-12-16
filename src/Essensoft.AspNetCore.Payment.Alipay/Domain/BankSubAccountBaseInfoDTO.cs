using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BankSubAccountBaseInfoDTO Data Structure.
    /// </summary>
    public class BankSubAccountBaseInfoDTO : AlipayObject
    {
        /// <summary>
        /// 主账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 用于收款交易的账号
        /// </summary>
        [JsonPropertyName("account_no_4_credit_transfer")]
        public string AccountNo4CreditTransfer { get; set; }

        /// <summary>
        /// 账户所在两位国家代码
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 主账号币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 全球化语言账户名称，一般为英文
        /// </summary>
        [JsonPropertyName("global_account_name")]
        public string GlobalAccountName { get; set; }

        /// <summary>
        /// 全球化语言银行名称
        /// </summary>
        [JsonPropertyName("global_bank_name")]
        public string GlobalBankName { get; set; }

        /// <summary>
        /// 全球化语言支行名称
        /// </summary>
        [JsonPropertyName("global_branch_name")]
        public string GlobalBranchName { get; set; }

        /// <summary>
        /// 全球化语言分行名称
        /// </summary>
        [JsonPropertyName("global_sub_bank_name")]
        public string GlobalSubBankName { get; set; }

        /// <summary>
        /// 当地语言的账户名
        /// </summary>
        [JsonPropertyName("local_account_name")]
        public string LocalAccountName { get; set; }

        /// <summary>
        /// 当地语言银行名称
        /// </summary>
        [JsonPropertyName("local_bank_name")]
        public string LocalBankName { get; set; }

        /// <summary>
        /// 当地语言用于交易的银行名称(通常为支行名称，当支行名称为空时取分行名称)
        /// </summary>
        [JsonPropertyName("local_bank_name_4_transfer")]
        public string LocalBankName4Transfer { get; set; }

        /// <summary>
        /// 当地语言支行名称
        /// </summary>
        [JsonPropertyName("local_branch_name")]
        public string LocalBranchName { get; set; }

        /// <summary>
        /// 当地语言分行名称
        /// </summary>
        [JsonPropertyName("local_sub_bank_name")]
        public string LocalSubBankName { get; set; }

        /// <summary>
        /// 全球化语言银行缩写
        /// </summary>
        [JsonPropertyName("out_fin_inst_abbreviation")]
        public string OutFinInstAbbreviation { get; set; }

        /// <summary>
        /// 子账号，如：0000000001
        /// </summary>
        [JsonPropertyName("sub_account_no")]
        public string SubAccountNo { get; set; }

        /// <summary>
        /// 归属业务类型，如：LIGHTS
        /// </summary>
        [JsonPropertyName("treasury_biz_type")]
        public string TreasuryBizType { get; set; }

        /// <summary>
        /// 归属业务类型名称
        /// </summary>
        [JsonPropertyName("treasury_biz_type_name")]
        public string TreasuryBizTypeName { get; set; }
    }
}
