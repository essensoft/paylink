using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessBankAccountInfo Data Structure.
    /// </summary>
    public class BusinessBankAccountInfo : AlipayObject
    {
        /// <summary>
        /// 企业对公账户名称
        /// </summary>
        [JsonPropertyName("business_bank_account_name")]
        public string BusinessBankAccountName { get; set; }

        /// <summary>
        /// 企业对公银行账户号
        /// </summary>
        [JsonPropertyName("business_bank_card_no")]
        public string BusinessBankCardNo { get; set; }

        /// <summary>
        /// 企业对公账户开户行名称
        /// </summary>
        [JsonPropertyName("business_bank_name")]
        public string BusinessBankName { get; set; }

        /// <summary>
        /// 企业对公账户开户行支行全称
        /// </summary>
        [JsonPropertyName("business_bank_sub")]
        public string BusinessBankSub { get; set; }
    }
}
