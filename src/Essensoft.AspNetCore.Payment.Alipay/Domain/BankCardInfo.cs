using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BankCardInfo Data Structure.
    /// </summary>
    public class BankCardInfo : AlipayObject
    {
        /// <summary>
        /// 银行开户行名称。填写支行名称。
        /// </summary>
        [JsonPropertyName("bank_branch_name")]
        public string BankBranchName { get; set; }

        /// <summary>
        /// 银行卡持卡人姓名
        /// </summary>
        [JsonPropertyName("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }
    }
}
