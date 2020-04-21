using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandStoreShopserviceDeleteModel Data Structure.
    /// </summary>
    public class AntMerchantExpandStoreShopserviceDeleteModel : AlipayObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 线下店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 场景服务ID
        /// </summary>
        [JsonPropertyName("shop_service_id")]
        public string ShopServiceId { get; set; }

        /// <summary>
        /// SKU的ID
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 线上门店ID，插件协议的入参
        /// </summary>
        [JsonPropertyName("store_open_id")]
        public string StoreOpenId { get; set; }
    }
}
