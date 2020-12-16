using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopBatchqueryResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryMerchantshopBatchqueryResponse : AlipayResponse
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
        /// 门店列表数据。
        /// </summary>
        [JsonPropertyName("records")]
        public MerchantShopDTO Records { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [JsonPropertyName("total_no")]
        public long TotalNo { get; set; }
    }
}
