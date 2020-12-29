using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmInstanceCreateResponse.
    /// </summary>
    public class AlipayIserviceCcmInstanceCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 租户实例（数据权限）ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
