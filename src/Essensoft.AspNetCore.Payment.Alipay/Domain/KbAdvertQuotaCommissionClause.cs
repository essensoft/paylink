using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertQuotaCommissionClause Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertQuotaCommissionClause : AlipayObject
    {
        /// <summary>
        /// 固定金额
        /// </summary>
        [JsonProperty("quota_amount")]
        [XmlElement("quota_amount")]
        public string QuotaAmount { get; set; }
    }
}
