using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenPromoBudget Data Structure.
    /// </summary>
    [Serializable]
    public class OpenPromoBudget : AlipayObject
    {
        /// <summary>
        /// 预算数量，支持1～999999999之间。默认为999999999
        /// </summary>
        [JsonProperty("budget_total")]
        [XmlElement("budget_total")]
        public string BudgetTotal { get; set; }

        /// <summary>
        /// 预算类型，现在支持CAMP_BUDGET_AMOUNT：表示数量预算
        /// </summary>
        [JsonProperty("budget_type")]
        [XmlElement("budget_type")]
        public string BudgetType { get; set; }
    }
}
