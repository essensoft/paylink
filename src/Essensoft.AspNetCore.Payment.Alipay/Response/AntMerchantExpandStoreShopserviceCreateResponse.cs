using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandStoreShopserviceCreateResponse.
    /// </summary>
    public class AntMerchantExpandStoreShopserviceCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 场景服务ID
        /// </summary>
        [JsonPropertyName("shop_service_id")]
        public string ShopServiceId { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
