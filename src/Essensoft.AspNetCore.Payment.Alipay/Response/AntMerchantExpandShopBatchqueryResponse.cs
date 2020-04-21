using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandShopBatchqueryResponse.
    /// </summary>
    public class AntMerchantExpandShopBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页数量
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 线下门店的列表;有可能为空
        /// </summary>
        [JsonPropertyName("shops")]
        public List<SimpleShopInfo> Shops { get; set; }

        /// <summary>
        /// 按照分页数量拆分，分解出来的页数
        /// </summary>
        [JsonPropertyName("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 所有线下门店数量
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }
    }
}
