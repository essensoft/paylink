using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcBindModifyResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcBindModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否更新成功；true成功/false失败
        /// </summary>
        [JsonPropertyName("update_result")]
        public bool UpdateResult { get; set; }
    }
}
