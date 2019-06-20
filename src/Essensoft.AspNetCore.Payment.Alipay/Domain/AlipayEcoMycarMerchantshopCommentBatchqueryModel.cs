using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarMerchantshopCommentBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMerchantshopCommentBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页号（从1开始）
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页数量，每页不超过100条。
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public long ShopId { get; set; }
    }
}
