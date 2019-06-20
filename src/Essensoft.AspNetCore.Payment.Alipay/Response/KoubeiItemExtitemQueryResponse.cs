using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemExtitemQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonProperty("extitem")]
        public ExtItem Extitem { get; set; }
    }
}
