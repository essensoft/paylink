using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BudgetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BudgetInfo : AlipayObject
    {
        /// <summary>
        /// 预算数量
        /// </summary>
        [JsonProperty("budget_total")]
        [XmlElement("budget_total")]
        public string BudgetTotal { get; set; }

        /// <summary>
        /// 预算类型
        /// </summary>
        [JsonProperty("budget_type")]
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 设置每天的预算，如每天的预算设置为100，即该活动一天最多发放100次
        /// </summary>
        [JsonProperty("sub_budget_dimension")]
        [XmlElement("sub_budget_dimension")]
        public string SubBudgetDimension { get; set; }

        /// <summary>
        /// 用于控制子纬度的预算数量
        /// </summary>
        [JsonProperty("sub_value")]
        [XmlElement("sub_value")]
        public string SubValue { get; set; }
    }
}
