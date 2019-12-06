using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtCardInfo Data Structure.
    /// </summary>
    public class ExtCardInfo : AlipayObject
    {
        /// <summary>
        /// 托管子户外卡户名
        /// </summary>
        [JsonPropertyName("bank_acc_name")]
        public string BankAccName { get; set; }

        /// <summary>
        /// 托管子户外卡开户行
        /// </summary>
        [JsonPropertyName("card_bank")]
        public string CardBank { get; set; }

        /// <summary>
        /// 托管子户外卡支行
        /// </summary>
        [JsonPropertyName("card_branch")]
        public string CardBranch { get; set; }

        /// <summary>
        /// 托管子户外卡联行号
        /// </summary>
        [JsonPropertyName("card_deposit")]
        public string CardDeposit { get; set; }

        /// <summary>
        /// 托管子户外卡开户地址
        /// </summary>
        [JsonPropertyName("card_location")]
        public string CardLocation { get; set; }

        /// <summary>
        /// 托管子户的外卡卡号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 托管子户外卡状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
