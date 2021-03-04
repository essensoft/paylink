using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusCreateResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 作品列表
        /// </summary>
        [JsonPropertyName("opuses")]
        public OpusCreateResponse Opuses { get; set; }
    }
}
