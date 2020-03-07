using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneCommandReceiveResponse.
    /// </summary>
    public class AlipayInsSceneCommandReceiveResponse : AlipayResponse
    {
        /// <summary>
        /// 执行结果JSON字符串
        /// </summary>
        [JsonPropertyName("result_object_string")]
        public string ResultObjectString { get; set; }
    }
}
