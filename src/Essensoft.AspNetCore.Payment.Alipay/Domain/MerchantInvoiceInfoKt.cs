using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantInvoiceInfoKt Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantInvoiceInfoKt : AlipayObject
    {
        /// <summary>
        /// 是否接受电子发票 true/false
        /// </summary>
        [JsonProperty("accept_electronic")]
        public bool AcceptElectronic { get; set; }

        /// <summary>
        /// 开票地址
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// 是否自动开票，值为true/false
        /// </summary>
        [JsonProperty("auto_invoice")]
        public bool AutoInvoice { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 收件人地址
        /// </summary>
        [JsonProperty("mail_address")]
        public AddressInfoKt MailAddress { get; set; }

        /// <summary>
        /// 收件人名称
        /// </summary>
        [JsonProperty("mail_name")]
        public string MailName { get; set; }

        /// <summary>
        /// 寄送电话
        /// </summary>
        [JsonProperty("mail_telephone")]
        public string MailTelephone { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [JsonProperty("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 纳税人资格种类:01一般纳税人，02小规模纳税人。一般纳税人开的是专票
        /// </summary>
        [JsonProperty("tax_payer_qualification")]
        public string TaxPayerQualification { get; set; }

        /// <summary>
        /// 纳税人资格开始时间,yyyyMMdd格式
        /// </summary>
        [JsonProperty("tax_payer_valid")]
        public string TaxPayerValid { get; set; }

        /// <summary>
        /// 开票电话
        /// </summary>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
