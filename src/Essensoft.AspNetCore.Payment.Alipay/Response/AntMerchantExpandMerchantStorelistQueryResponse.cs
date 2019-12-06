using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandMerchantStorelistQueryResponse.
    /// </summary>
    public class AntMerchantExpandMerchantStorelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户门店列表
        /// </summary>
        [JsonPropertyName("merchant_stores")]
        public List<ShopQueryInfo> MerchantStores { get; set; }

        /// <summary>
        /// 当前页码,页码从1开始
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }
    }
}
