using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceTitleQueryOpenModel Data Structure.
    /// </summary>
    public class InvoiceTitleQueryOpenModel : AlipayObject
    {
        /// <summary>
        /// 购买方地址
        /// </summary>
        [JsonPropertyName("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 开户行账户
        /// </summary>
        [JsonPropertyName("payer_bank_account")]
        public string PayerBankAccount { get; set; }

        /// <summary>
        /// 购买方开户银行
        /// </summary>
        [JsonPropertyName("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购买方纳税人识别号
        /// </summary>
        [JsonPropertyName("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        [JsonPropertyName("payer_tel")]
        public string PayerTel { get; set; }

        /// <summary>
        /// 发票抬头名称
        /// </summary>
        [JsonPropertyName("title_name")]
        public string TitleName { get; set; }

        /// <summary>
        /// 支付宝用户id，支付宝用户的唯一标识。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
