using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPortfolioShopBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiServindustryPortfolioShopBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 插件id
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 当前页码；页码必须大于等于1；最大值：100
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小;默认值：20；最大值：100
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
