using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataDashboardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataDashboardQueryModel : AlipayObject
    {
        /// <summary>
        /// 仪表盘ID
        /// </summary>
        [JsonProperty("dashboard_id")]
        [XmlElement("dashboard_id")]
        public string DashboardId { get; set; }

        /// <summary>
        /// 仪表盘过滤条件
        /// </summary>
        [JsonProperty("param")]
        [XmlArray("param")]
        [XmlArrayItem("dashboard_param")]
        public List<DashboardParam> Param { get; set; }
    }
}
