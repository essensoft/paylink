using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StuffStockOutOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class StuffStockOutOrderItem : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 发货数量
        /// </summary>
        [JsonProperty("item_quantity")]
        public long ItemQuantity { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [JsonProperty("sku_no")]
        public string SkuNo { get; set; }
    }
}
