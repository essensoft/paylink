using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAccountQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户pid
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
