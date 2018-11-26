using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantInvoiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantInvoiceInfo : AlipayObject
    {
        /// <summary>
        /// 是否接受电子发票 true/false
        /// </summary>
        [JsonProperty("accept_electronic")]
        [XmlElement("accept_electronic")]
        public bool AcceptElectronic { get; set; }

        /// <summary>
        /// 开票地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 是否自动开票，值为true/false
        /// </summary>
        [JsonProperty("auto_invoice")]
        [XmlElement("auto_invoice")]
        public bool AutoInvoice { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [JsonProperty("bank_account")]
        [XmlElement("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [JsonProperty("bank_name")]
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 收件人地址
        /// </summary>
        [JsonProperty("mail_address")]
        [XmlElement("mail_address")]
        public AddressInfo MailAddress { get; set; }

        /// <summary>
        /// 收件人名称
        /// </summary>
        [JsonProperty("mail_name")]
        [XmlElement("mail_name")]
        public string MailName { get; set; }

        /// <summary>
        /// 057162288888
        /// </summary>
        [JsonProperty("mail_telephone")]
        [XmlElement("mail_telephone")]
        public string MailTelephone { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [JsonProperty("tax_no")]
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 纳税人资格种类:01一般纳税人，02小规模纳税人。一般纳税人开的是专票
        /// </summary>
        [JsonProperty("tax_payer_qualification")]
        [XmlElement("tax_payer_qualification")]
        public string TaxPayerQualification { get; set; }

        /// <summary>
        /// 纳税人资格开始时间,yyyyMMdd格式
        /// </summary>
        [JsonProperty("tax_payer_valid")]
        [XmlElement("tax_payer_valid")]
        public string TaxPayerValid { get; set; }

        /// <summary>
        /// 开票电话
        /// </summary>
        [JsonProperty("telephone")]
        [XmlElement("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
