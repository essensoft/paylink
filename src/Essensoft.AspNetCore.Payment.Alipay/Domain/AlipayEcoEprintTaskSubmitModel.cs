using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintTaskSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintTaskSubmitModel : AlipayObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用Secret
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 打印内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 应用访问凭证
        /// </summary>
        [JsonProperty("eprint_token")]
        public string EprintToken { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonProperty("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 业务内部编号
        /// </summary>
        [JsonProperty("origin_id")]
        public string OriginId { get; set; }
    }
}
