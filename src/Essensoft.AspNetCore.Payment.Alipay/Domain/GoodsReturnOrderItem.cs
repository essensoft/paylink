using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsReturnOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsReturnOrderItem : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 单价，单位：元，没有设置0
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("qty")]
        public string Qty { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        [JsonProperty("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// sku号
        /// </summary>
        [JsonProperty("sku_no")]
        public string SkuNo { get; set; }
    }
}
