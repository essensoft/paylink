using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertPreserveCommissionClause Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertPreserveCommissionClause : AlipayObject
    {
        /// <summary>
        /// user_id：支付宝账户ID(2088开头)  logon_id：登陆账号
        /// </summary>
        [JsonProperty("claimer_id_type")]
        [XmlElement("claimer_id_type")]
        public string ClaimerIdType { get; set; }

        /// <summary>
        /// 认领人
        /// </summary>
        [JsonProperty("claimers")]
        [XmlArray("claimers")]
        [XmlArrayItem("string")]
        public List<string> Claimers { get; set; }
    }
}
