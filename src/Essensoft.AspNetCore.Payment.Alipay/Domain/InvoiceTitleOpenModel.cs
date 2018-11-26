using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceTitleOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTitleOpenModel : AlipayObject
    {
        /// <summary>
        /// 票面上的购买方地址、电话
        /// </summary>
        [JsonProperty("payer_address_tel")]
        [XmlElement("payer_address_tel")]
        public string PayerAddressTel { get; set; }

        /// <summary>
        /// 票面上的购买方开户行及账户
        /// </summary>
        [JsonProperty("payer_bank_name_account")]
        [XmlElement("payer_bank_name_account")]
        public string PayerBankNameAccount { get; set; }

        /// <summary>
        /// 票面上的购买方纳税人识别号
        /// </summary>
        [JsonProperty("payer_register_no")]
        [XmlElement("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 票面上的购买方名称
        /// </summary>
        [JsonProperty("title_name")]
        [XmlElement("title_name")]
        public string TitleName { get; set; }
    }
}
