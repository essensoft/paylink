using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarMerchantshopCommentBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarMerchantshopCommentBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页号（从1开始）
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页数量，每页不超过100条。
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public long ShopId { get; set; }
    }
}
