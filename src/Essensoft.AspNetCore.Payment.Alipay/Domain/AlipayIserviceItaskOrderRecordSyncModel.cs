using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceItaskOrderRecordSyncModel Data Structure.
    /// </summary>
    public class AlipayIserviceItaskOrderRecordSyncModel : AlipayObject
    {
        /// <summary>
        /// 首页助理openapi请求入参
        /// </summary>
        [JsonPropertyName("home_api_request")]
        public HomeApiRequest HomeApiRequest { get; set; }
    }
}
