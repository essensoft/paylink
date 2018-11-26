using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertCommissionClauseQuota Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertCommissionClauseQuota : AlipayObject
    {
        /// <summary>
        /// 定额结束范围(精度2位的非负小数)
        /// </summary>
        [JsonProperty("quota_amount_end")]
        [XmlElement("quota_amount_end")]
        public string QuotaAmountEnd { get; set; }

        /// <summary>
        /// 定额开始范围(精度2位的非负小数)
        /// </summary>
        [JsonProperty("quota_amount_start")]
        [XmlElement("quota_amount_start")]
        public string QuotaAmountStart { get; set; }
    }
}
