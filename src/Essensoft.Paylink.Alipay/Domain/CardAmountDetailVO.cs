using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CardAmountDetailVO Data Structure.
    /// </summary>
    public class CardAmountDetailVO : AlipayObject
    {
        /// <summary>
        /// 转入金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 持卡人姓名
        /// </summary>
        [JsonPropertyName("card_holder_name")]
        public string CardHolderName { get; set; }

        /// <summary>
        /// 转入卡账号
        /// </summary>
        [JsonPropertyName("out_bank_card_no")]
        public string OutBankCardNo { get; set; }

        /// <summary>
        /// 转入行的银行机构id
        /// </summary>
        [JsonPropertyName("out_bank_inst_id")]
        public string OutBankInstId { get; set; }

        /// <summary>
        /// 转入行的银行名称
        /// </summary>
        [JsonPropertyName("out_bank_name")]
        public string OutBankName { get; set; }
    }
}
