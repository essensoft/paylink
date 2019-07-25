using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StuffStockInOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class StuffStockInOrderItem : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 入库单物料数量
        /// </summary>
        [JsonProperty("qty")]
        public long Qty { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [JsonProperty("sku_no")]
        public string SkuNo { get; set; }
    }
}
