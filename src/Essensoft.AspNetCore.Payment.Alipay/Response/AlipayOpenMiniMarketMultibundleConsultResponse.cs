using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniMarketMultibundleConsultResponse.
    /// </summary>
    public class AlipayOpenMiniMarketMultibundleConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 端ID
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 不同场景命中的营销信息列表
        /// </summary>
        [JsonPropertyName("market_result_list")]
        public List<MarketResult> MarketResultList { get; set; }

        /// <summary>
        /// 商户小程序ID
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
