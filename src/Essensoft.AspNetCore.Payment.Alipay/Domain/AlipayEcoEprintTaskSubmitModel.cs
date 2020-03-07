using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintTaskSubmitModel Data Structure.
    /// </summary>
    public class AlipayEcoEprintTaskSubmitModel : AlipayObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用Secret
        /// </summary>
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 打印内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 应用访问凭证
        /// </summary>
        [JsonPropertyName("eprint_token")]
        public string EprintToken { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonPropertyName("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 业务内部编号
        /// </summary>
        [JsonPropertyName("origin_id")]
        public string OriginId { get; set; }
    }
}
