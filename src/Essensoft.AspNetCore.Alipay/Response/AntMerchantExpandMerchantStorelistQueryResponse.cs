using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandMerchantStorelistQueryResponse.
    /// </summary>
    public class AntMerchantExpandMerchantStorelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户门店列表
        /// </summary>
        [JsonProperty("merchant_stores")]
        public List<ShopQueryInfo> MerchantStores { get; set; }

        /// <summary>
        /// 当前页码,页码从1开始
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total_size")]
        public long TotalSize { get; set; }
    }
}
