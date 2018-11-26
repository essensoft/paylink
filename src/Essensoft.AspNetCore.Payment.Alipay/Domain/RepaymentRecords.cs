using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RepaymentRecords Data Structure.
    /// </summary>
    [Serializable]
    public class RepaymentRecords : AlipayObject
    {
        /// <summary>
        /// 交易时间
        /// </summary>
        [JsonProperty("date")]
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 正常本金利息，单位为元，小数点保留2位
        /// </summary>
        [JsonProperty("interest")]
        [XmlElement("interest")]
        public string Interest { get; set; }

        /// <summary>
        /// 逾期本金利息，单位为元，小数点保留2位
        /// </summary>
        [JsonProperty("overdue_interest")]
        [XmlElement("overdue_interest")]
        public string OverdueInterest { get; set; }

        /// <summary>
        /// 逾期利息罚息，单位为元，小数点保留2位
        /// </summary>
        [JsonProperty("overdue_interest_penalty")]
        [XmlElement("overdue_interest_penalty")]
        public string OverdueInterestPenalty { get; set; }

        /// <summary>
        /// 逾期本金，单位为元，小数点保留2位
        /// </summary>
        [JsonProperty("overdue_principal")]
        [XmlElement("overdue_principal")]
        public string OverduePrincipal { get; set; }

        /// <summary>
        /// 逾期本金罚息，单位为元，小数点保留2位
        /// </summary>
        [JsonProperty("overdue_principal_penalty")]
        [XmlElement("overdue_principal_penalty")]
        public string OverduePrincipalPenalty { get; set; }

        /// <summary>
        /// 正常本金，单位为元，小数点保留2位
        /// </summary>
        [JsonProperty("principal")]
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remarks")]
        [XmlElement("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 交易总金额
        /// </summary>
        [JsonProperty("total_amount")]
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
