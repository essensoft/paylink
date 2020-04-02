using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandShopBatchqueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandShopBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页数量, 最大50
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 插件业务场景code，预约为SHOP_SERVICE
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 线上店ID
        /// </summary>
        [JsonPropertyName("store_open_id")]
        public string StoreOpenId { get; set; }
    }
}
