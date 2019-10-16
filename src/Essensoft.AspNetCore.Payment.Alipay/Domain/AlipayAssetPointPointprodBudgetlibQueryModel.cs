using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointPointprodBudgetlibQueryModel : AlipayObject
    {
        /// <summary>
        /// 预算库编码
        /// </summary>
        [JsonProperty("budget_code")]
        public string BudgetCode { get; set; }
    }
}
