using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserPeerpayprodAgreementQueryResponse.
    /// </summary>
    public class AlipayUserPeerpayprodAgreementQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 亲情号协议的额度
        /// </summary>
        [JsonPropertyName("quota")]
        public long Quota { get; set; }
    }
}
