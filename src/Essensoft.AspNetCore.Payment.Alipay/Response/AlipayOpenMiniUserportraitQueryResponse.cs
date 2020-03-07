using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniUserportraitQueryResponse.
    /// </summary>
    public class AlipayOpenMiniUserportraitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户画像
        /// </summary>
        [JsonPropertyName("portrait_distributions")]
        public List<PortraitDistribution> PortraitDistributions { get; set; }
    }
}
