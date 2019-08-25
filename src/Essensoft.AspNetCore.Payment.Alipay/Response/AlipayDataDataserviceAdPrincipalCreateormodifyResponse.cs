using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipalCreateormodifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPrincipalCreateormodifyResponse : AlipayResponse
    {
        /// <summary>
        /// 商家id
        /// </summary>
        [JsonProperty("principal_id")]
        public long PrincipalId { get; set; }
    }
}
