using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OutStockStuffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OutStockStuffInfo : AlipayObject
    {
        /// <summary>
        /// 实出库数量
        /// </summary>
        [JsonProperty("actual_qty")]
        public long ActualQty { get; set; }

        /// <summary>
        /// 扩展
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 物料sku
        /// </summary>
        [JsonProperty("sku_no")]
        public string SkuNo { get; set; }
    }
}
