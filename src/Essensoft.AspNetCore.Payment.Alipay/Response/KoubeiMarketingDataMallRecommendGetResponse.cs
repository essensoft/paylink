using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallRecommendGetResponse.
    /// </summary>
    public class KoubeiMarketingDataMallRecommendGetResponse : AlipayResponse
    {
        /// <summary>
        /// 是否还有更多数据：true-是，false-否
        /// </summary>
        [JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 商圈商品券结构商圈商
        /// </summary>
        [JsonPropertyName("items")]
        public List<ItemResp> Items { get; set; }
    }
}
