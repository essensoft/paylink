using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ThirdErrorContext Data Structure.
    /// </summary>
    public class ThirdErrorContext : AlipayObject
    {
        /// <summary>
        /// 支付宝三代错误码内部值
        /// </summary>
        [JsonPropertyName("third_error_code")]
        public string ThirdErrorCode { get; set; }

        /// <summary>
        /// thirdErrorCode的错误描述
        /// </summary>
        [JsonPropertyName("third_error_msg")]
        public string ThirdErrorMsg { get; set; }
    }
}
