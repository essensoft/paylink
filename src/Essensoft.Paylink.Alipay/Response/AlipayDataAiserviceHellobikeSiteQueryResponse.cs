using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceHellobikeSiteQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceHellobikeSiteQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public SiteResult Result { get; set; }
    }
}
