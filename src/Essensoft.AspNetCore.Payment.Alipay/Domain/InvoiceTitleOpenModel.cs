using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceTitleOpenModel Data Structure.
    /// </summary>
    public class InvoiceTitleOpenModel : AlipayObject
    {
        /// <summary>
        /// 票面上的购买方地址、电话
        /// </summary>
        [JsonPropertyName("payer_address_tel")]
        public string PayerAddressTel { get; set; }

        /// <summary>
        /// 票面上的购买方开户行及账户
        /// </summary>
        [JsonPropertyName("payer_bank_name_account")]
        public string PayerBankNameAccount { get; set; }

        /// <summary>
        /// 票面上的购买方纳税人识别号
        /// </summary>
        [JsonPropertyName("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 票面上的购买方名称
        /// </summary>
        [JsonPropertyName("title_name")]
        public string TitleName { get; set; }
    }
}
