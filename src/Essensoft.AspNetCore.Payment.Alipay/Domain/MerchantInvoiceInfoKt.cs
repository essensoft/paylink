using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantInvoiceInfoKt Data Structure.
    /// </summary>
    public class MerchantInvoiceInfoKt : AlipayObject
    {
        /// <summary>
        /// 是否接受电子发票 true/false
        /// </summary>
        [JsonPropertyName("accept_electronic")]
        public bool AcceptElectronic { get; set; }

        /// <summary>
        /// 开票地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 是否自动开票，值为true/false
        /// </summary>
        [JsonPropertyName("auto_invoice")]
        public bool AutoInvoice { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [JsonPropertyName("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 收件人地址
        /// </summary>
        [JsonPropertyName("mail_address")]
        public AddressInfoKt MailAddress { get; set; }

        /// <summary>
        /// 收件人名称
        /// </summary>
        [JsonPropertyName("mail_name")]
        public string MailName { get; set; }

        /// <summary>
        /// 寄送电话
        /// </summary>
        [JsonPropertyName("mail_telephone")]
        public string MailTelephone { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [JsonPropertyName("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 纳税人资格种类:01一般纳税人，02小规模纳税人。一般纳税人开的是专票
        /// </summary>
        [JsonPropertyName("tax_payer_qualification")]
        public string TaxPayerQualification { get; set; }

        /// <summary>
        /// 纳税人资格开始时间,yyyyMMdd格式
        /// </summary>
        [JsonPropertyName("tax_payer_valid")]
        public string TaxPayerValid { get; set; }

        /// <summary>
        /// 开票电话
        /// </summary>
        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
