using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArrangementConditionGroupSelector Data Structure.
    /// </summary>
    [Serializable]
    public class ArrangementConditionGroupSelector : AlipayObject
    {
        /// <summary>
        /// 是否选择最新的产品条件,默认为TRUE
        /// </summary>
        [JsonProperty("select_latest_pd_cd")]
        [XmlElement("select_latest_pd_cd")]
        public bool SelectLatestPdCd { get; set; }
    }
}
