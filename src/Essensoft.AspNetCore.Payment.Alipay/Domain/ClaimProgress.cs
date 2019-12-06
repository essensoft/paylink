using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ClaimProgress Data Structure.
    /// </summary>
    public class ClaimProgress : AlipayObject
    {
        /// <summary>
        /// 更新内容
        /// </summary>
        [JsonPropertyName("update_content")]
        public string UpdateContent { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; }
    }
}
