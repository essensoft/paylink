using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CodeInfo Data Structure.
    /// </summary>
    public class CodeInfo : AlipayObject
    {
        /// <summary>
        /// 跳转URL，扫码关注服务窗后会直接跳转到此URL
        /// </summary>
        [JsonPropertyName("goto_url")]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        [JsonPropertyName("scene")]
        public Scene Scene { get; set; }
    }
}
