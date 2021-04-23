using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HealthServiceItem Data Structure.
    /// </summary>
    public class HealthServiceItem : AlipayObject
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商家的商品条形码
        /// </summary>
        [JsonPropertyName("merchant_item_bar_code")]
        public string MerchantItemBarCode { get; set; }

        /// <summary>
        /// 商家的商品编码
        /// </summary>
        [JsonPropertyName("merchant_item_code")]
        public string MerchantItemCode { get; set; }

        /// <summary>
        /// 售价 单位：分
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品的sku列表（已废弃，使用skus字段）
        /// </summary>
        [JsonPropertyName("sku_list")]
        public HealthServiceSku SkuList { get; set; }

        /// <summary>
        /// sku列表
        /// </summary>
        [JsonPropertyName("skus")]
        public List<HealthServiceSku> Skus { get; set; }
    }
}
