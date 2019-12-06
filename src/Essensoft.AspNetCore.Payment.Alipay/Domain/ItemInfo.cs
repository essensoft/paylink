using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemInfo Data Structure.
    /// </summary>
    public class ItemInfo : AlipayObject
    {
        /// <summary>
        /// 券适用的单品码列表  最少配置1个单品码  最多配置500个单品码
        /// </summary>
        [JsonPropertyName("item_ids")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 单品图片列表  单品图片不能超过3张
        /// </summary>
        [JsonPropertyName("item_imgs")]
        public List<string> ItemImgs { get; set; }

        /// <summary>
        /// 单品券详细介绍跳转链接
        /// </summary>
        [JsonPropertyName("item_link")]
        public string ItemLink { get; set; }

        /// <summary>
        /// 单品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 单品券说明
        /// </summary>
        [JsonPropertyName("item_text")]
        public string ItemText { get; set; }

        /// <summary>
        /// 单品券适用的商品列表中，每一个商品最高可享受优惠的件数；    如：券适用于A,B两种商品，该字段设置为1，则用券A,B两种商品每种最多只有一件可享受优惠；
        /// </summary>
        [JsonPropertyName("max_discount_num")]
        public string MaxDiscountNum { get; set; }

        /// <summary>
        /// 单品券适用商品列表中，每种商品享受优惠最低购买件数的门槛；  如：券适用于A,B两种商品，该字段设置为3，则A,B两种商品每种最少需要购买3件才可享受优惠；
        /// </summary>
        [JsonPropertyName("min_consume_num")]
        public string MinConsumeNum { get; set; }

        /// <summary>
        /// 单品的原价，单位元  必须为合法金额类型字符串，如9.99
        /// </summary>
        [JsonPropertyName("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 券适用SKU的最低消费金额门槛  如券适用A,B两个SKU，该字段设置的值为100，则订单中购买A,B两个SKU的合计金额需大于100元才可用券
        /// </summary>
        [JsonPropertyName("sku_min_consume")]
        public string SkuMinConsume { get; set; }

        /// <summary>
        /// 如果一个单品券适用A，B，C三个单品，若设置了该字段为2，则在一笔交易中，A，B，C三个单品加起来最多只有俩件能够享受优惠
        /// </summary>
        [JsonPropertyName("total_max_discount_num")]
        public string TotalMaxDiscountNum { get; set; }
    }
}
