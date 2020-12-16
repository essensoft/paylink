using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MarketResult Data Structure.
    /// </summary>
    public class MarketResult : AlipayObject
    {
        /// <summary>
        /// 营销信息列表
        /// </summary>
        [JsonPropertyName("price_detail_list")]
        public List<PriceDetailDTO> PriceDetailList { get; set; }

        /// <summary>
        /// 用于区分营销场景，例如打车星巴克
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
