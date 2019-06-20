using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BudgetVO Data Structure.
    /// </summary>
    [Serializable]
    public class BudgetVO : AlipayObject
    {
        /// <summary>
        /// 应还总金额 = 正常本金+逾期本金+正常利息+逾期利息+逾期本金罚息+逾期利息罚息
        /// </summary>
        [JsonProperty("need_repay_total")]
        public string NeedRepayTotal { get; set; }

        /// <summary>
        /// 正常利息
        /// </summary>
        [JsonProperty("nom_int")]
        public string NomInt { get; set; }

        /// <summary>
        /// 正常本金
        /// </summary>
        [JsonProperty("nom_prin")]
        public string NomPrin { get; set; }

        /// <summary>
        /// 逾期利息
        /// </summary>
        [JsonProperty("ovd_int")]
        public string OvdInt { get; set; }

        /// <summary>
        /// 逾期利息罚息
        /// </summary>
        [JsonProperty("ovd_int_pen_int")]
        public string OvdIntPenInt { get; set; }

        /// <summary>
        /// 逾期本金
        /// </summary>
        [JsonProperty("ovd_prin")]
        public string OvdPrin { get; set; }

        /// <summary>
        /// 逾期本金罚息
        /// </summary>
        [JsonProperty("ovd_prin_pen_int")]
        public string OvdPrinPenInt { get; set; }
    }
}
