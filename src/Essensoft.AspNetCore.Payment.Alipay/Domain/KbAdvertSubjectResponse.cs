using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertSubjectResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertSubjectResponse : AlipayObject
    {
        /// <summary>
        /// 分佣规则
        /// </summary>
        [JsonProperty("commission_clause")]
        [XmlElement("commission_clause")]
        public KbAdvertCommissionClauseResponse CommissionClause { get; set; }

        /// <summary>
        /// 标的类型  voucher-券
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 券标的  只有type=voucher才会有值
        /// </summary>
        [JsonProperty("voucher")]
        [XmlElement("voucher")]
        public KbAdvertSubjectVoucherResponse Voucher { get; set; }
    }
}
