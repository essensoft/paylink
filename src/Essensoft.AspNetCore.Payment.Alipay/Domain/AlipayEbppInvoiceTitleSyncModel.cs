using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceTitleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceTitleSyncModel : AlipayObject
    {
        /// <summary>
        /// 开户银行账号
        /// </summary>
        [JsonProperty("open_bank_account")]
        [XmlElement("open_bank_account")]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        [JsonProperty("open_bank_name")]
        [XmlElement("open_bank_name")]
        public string OpenBankName { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [JsonProperty("tax_register_no")]
        [XmlElement("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [JsonProperty("title_name")]
        [XmlElement("title_name")]
        public string TitleName { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("user_address")]
        [XmlElement("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonProperty("user_mobile")]
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }
    }
}
