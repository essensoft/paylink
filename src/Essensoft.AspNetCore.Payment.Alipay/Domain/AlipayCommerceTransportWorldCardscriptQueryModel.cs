using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportWorldCardscriptQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportWorldCardscriptQueryModel : AlipayObject
    {
        /// <summary>
        /// 脚本名称
        /// </summary>
        [JsonPropertyName("script_name")]
        public string ScriptName { get; set; }

        /// <summary>
        /// 脚本类型
        /// </summary>
        [JsonPropertyName("script_type")]
        public string ScriptType { get; set; }
    }
}
