using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenBpaasContractQueryResponse.
    /// </summary>
    public class AlipayOpenBpaasContractQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 签约状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
