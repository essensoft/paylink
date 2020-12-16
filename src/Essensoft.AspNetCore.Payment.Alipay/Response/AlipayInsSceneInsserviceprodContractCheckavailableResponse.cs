using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodContractCheckavailableResponse.
    /// </summary>
    public class AlipayInsSceneInsserviceprodContractCheckavailableResponse : AlipayResponse
    {
        /// <summary>
        /// INIT：未生效 FINISHED：服务已完结，无法提供服务 EFFECTIVE：生效中，可以提供服务 RELEASED：服务已解约，无法提供服务 CLOSED：已关闭
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
