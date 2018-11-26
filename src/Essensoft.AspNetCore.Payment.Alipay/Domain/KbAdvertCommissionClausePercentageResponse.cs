using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertCommissionClausePercentageResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertCommissionClausePercentageResponse : AlipayObject
    {
        /// <summary>
        /// 分佣比例(100以内精度2位的非负小数)
        /// </summary>
        [JsonProperty("commission_rate")]
        [XmlElement("commission_rate")]
        public string CommissionRate { get; set; }

        /// <summary>
        /// 封顶金额(精度2位的非负小数)
        /// </summary>
        [JsonProperty("max_limit")]
        [XmlElement("max_limit")]
        public string MaxLimit { get; set; }
    }
}
