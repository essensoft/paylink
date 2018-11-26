using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SettleCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SettleCardInfo : AlipayObject
    {
        /// <summary>
        /// 开户支行名
        /// </summary>
        [JsonProperty("account_branch_name")]
        [XmlElement("account_branch_name")]
        public string AccountBranchName { get; set; }

        /// <summary>
        /// 卡户名
        /// </summary>
        [JsonProperty("account_holder_name")]
        [XmlElement("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// 开户行所在地-市
        /// </summary>
        [JsonProperty("account_inst_city")]
        [XmlElement("account_inst_city")]
        public string AccountInstCity { get; set; }

        /// <summary>
        /// 开户行简称缩写
        /// </summary>
        [JsonProperty("account_inst_id")]
        [XmlElement("account_inst_id")]
        public string AccountInstId { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [JsonProperty("account_inst_name")]
        [XmlElement("account_inst_name")]
        public string AccountInstName { get; set; }

        /// <summary>
        /// 开户行所在地-省
        /// </summary>
        [JsonProperty("account_inst_province")]
        [XmlElement("account_inst_province")]
        public string AccountInstProvince { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("account_no")]
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 卡类型  借记卡-DC  信用卡-CC
        /// </summary>
        [JsonProperty("account_type")]
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 联行号
        /// </summary>
        [JsonProperty("bank_code")]
        [XmlElement("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 账号使用类型  对公-01  对私-02
        /// </summary>
        [JsonProperty("usage_type")]
        [XmlElement("usage_type")]
        public string UsageType { get; set; }
    }
}
