using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodUserCertifyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodUserCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// 验证结果
        /// </summary>
        [JsonProperty("agent_cert_result")]
        public string AgentCertResult { get; set; }
    }
}
