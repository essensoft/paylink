using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataDashboardApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataDashboardApplyModel : AlipayObject
    {
        /// <summary>
        /// 仪表盘ID列表
        /// </summary>
        [JsonProperty("dashboard_ids")]
        [XmlArray("dashboard_ids")]
        [XmlArrayItem("string")]
        public List<string> DashboardIds { get; set; }
    }
}
