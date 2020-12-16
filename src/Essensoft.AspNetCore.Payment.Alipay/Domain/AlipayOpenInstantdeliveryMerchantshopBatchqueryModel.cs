using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页数量, 最大50。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商家门店编码。
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }
    }
}
