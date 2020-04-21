using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ErrorCodeDTO Data Structure.
    /// </summary>
    public class ErrorCodeDTO : AlipayObject
    {
        /// <summary>
        /// jsapi参数描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 错误码,SYSTEM_ERROR:系统错误
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误解决方案
        /// </summary>
        [JsonPropertyName("solution")]
        public string Solution { get; set; }
    }
}
