using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InStockStuffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InStockStuffInfo : AlipayObject
    {
        /// <summary>
        /// 实收数量
        /// </summary>
        [JsonProperty("actual_qty")]
        public string ActualQty { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 计划数量
        /// </summary>
        [JsonProperty("plan_qty")]
        public long PlanQty { get; set; }

        /// <summary>
        /// 物料sku
        /// </summary>
        [JsonProperty("sku_no")]
        public string SkuNo { get; set; }
    }
}
