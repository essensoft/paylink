using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleSyncModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceTitleSyncModel : AlipayObject
    {
        /// <summary>
        /// 开户银行账号
        /// </summary>
        [JsonPropertyName("open_bank_account")]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [JsonPropertyName("open_bank_name")]
        public string OpenBankName { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [JsonPropertyName("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [JsonPropertyName("title_name")]
        public string TitleName { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonPropertyName("user_mobile")]
        public string UserMobile { get; set; }
    }
}
