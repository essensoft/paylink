using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceTitleQueryOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTitleQueryOpenModel : AlipayObject
    {
        /// <summary>
        /// 购买方地址
        /// </summary>
        [JsonProperty("payer_address")]
        [XmlElement("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 开户行账户
        /// </summary>
        [JsonProperty("payer_bank_account")]
        [XmlElement("payer_bank_account")]
        public string PayerBankAccount { get; set; }

        /// <summary>
        /// 购买方开户银行
        /// </summary>
        [JsonProperty("payer_bank_name")]
        [XmlElement("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购买方纳税人识别号
        /// </summary>
        [JsonProperty("payer_register_no")]
        [XmlElement("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        [JsonProperty("payer_tel")]
        [XmlElement("payer_tel")]
        public string PayerTel { get; set; }

        /// <summary>
        /// 发票抬头名称
        /// </summary>
        [JsonProperty("title_name")]
        [XmlElement("title_name")]
        public string TitleName { get; set; }

        /// <summary>
        /// 支付宝用户id，支付宝用户的唯一标识。
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
