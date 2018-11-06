using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceTitleModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTitleModel : AlipayObject
    {
        /// <summary>
        /// 是否为用户设置默认抬头  字段值包括两种情况：  false（非默认）  true（默认抬头）
        /// </summary>
        [JsonProperty("is_default")]
        [XmlElement("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// 支付宝用户登录名
        /// </summary>
        [JsonProperty("logon_id")]
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 银行账号
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
        /// 纳税人识别号
        /// </summary>
        [JsonProperty("tax_register_no")]
        [XmlElement("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 用户私人手机号
        /// </summary>
        [JsonProperty("tele_phone_no")]
        [XmlElement("tele_phone_no")]
        public string TelePhoneNo { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [JsonProperty("title_name")]
        [XmlElement("title_name")]
        public string TitleName { get; set; }

        /// <summary>
        /// 抬头类型  字段值有两种情况抬:  PERSONAL（个人）   CORPORATION（单位）
        /// </summary>
        [JsonProperty("title_type")]
        [XmlElement("title_type")]
        public string TitleType { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("user_address")]
        [XmlElement("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("user_email")]
        [XmlElement("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonProperty("user_mobile")]
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }
    }
}
