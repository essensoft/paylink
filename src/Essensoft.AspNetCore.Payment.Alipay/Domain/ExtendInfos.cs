using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtendInfos Data Structure.
    /// </summary>
    public class ExtendInfos : AlipayObject
    {
        /// <summary>
        /// isv_pid
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
