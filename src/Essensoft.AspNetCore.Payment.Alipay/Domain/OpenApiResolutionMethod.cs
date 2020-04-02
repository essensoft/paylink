using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenApiResolutionMethod Data Structure.
    /// </summary>
    public class OpenApiResolutionMethod : AlipayObject
    {
        /// <summary>
        /// Otp校验方法的标识
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Otp校验方法是否需要用户交互
        /// </summary>
        [JsonPropertyName("requires_user_interaction")]
        public bool RequiresUserInteraction { get; set; }

        /// <summary>
        /// Otp校验方法类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Otp校验方法的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
