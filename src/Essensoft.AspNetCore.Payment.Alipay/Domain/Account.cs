using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Account Data Structure.
    /// </summary>
    [Serializable]
    public class Account : AlipayObject
    {
        /// <summary>
        /// json字符串，扩展信息，支付宝：alipayId，外部银行卡：银行机构名称、银行机构号（总行、支行）、对公/对私等
        /// </summary>
        [JsonProperty("account_ext")]
        [XmlElement("account_ext")]
        public string AccountExt { get; set; }

        /// <summary>
        /// 账户名称，如银行账户名,支付宝手机号、email
        /// </summary>
        [JsonProperty("account_name")]
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 资金账号,支付宝2088开头或银行卡号
        /// </summary>
        [JsonProperty("account_no")]
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户类型，ALIPAY(“ALIPAY”, “Alipay”, “支付宝账号”, “支付宝账号”),CURRENT(“CURRENT”, “MayiBank”, “网商银行账号”, “网商银行账号”),OUT_BANK(“OUT_BANK”, “OutBank”, “外部银行账号”, “外部银行账号”)
        /// </summary>
        [JsonProperty("account_type")]
        [XmlElement("account_type")]
        public string AccountType { get; set; }
    }
}
