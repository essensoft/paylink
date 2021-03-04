using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelPromotionGetResponse.
    /// </summary>
    public class AlipayOverseasTravelPromotionGetResponse : AlipayResponse
    {
        /// <summary>
        /// 优惠信息列表
        /// </summary>
        [JsonPropertyName("promotions")]
        public List<PromotionInfo> Promotions { get; set; }

        /// <summary>
        /// 入参匹配的优惠总数，分页使用
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
