using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemOrderInfo Data Structure.
    /// </summary>
    public class ItemOrderInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息，请参见产品文档。小程序订单助手业务中，扩展参数必须传递素材id；其他业务场景参见对应的产品文档。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品 id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量（单位：自拟）。 小程序订单助手业务中，为必传；其他业务场景参见对应的产品文档。
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品 sku id
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品单价（单位：元）。 小程序订单助手业务中，为必传；其他业务场景参见对应的产品文档。
        /// </summary>
        [JsonPropertyName("unit_price")]
        public string UnitPrice { get; set; }
    }
}
