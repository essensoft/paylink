using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthApiDTO Data Structure.
    /// </summary>
    public class AuthApiDTO : AlipayObject
    {
        /// <summary>
        /// 敏感信息可申请接口名
        /// </summary>
        [JsonPropertyName("api_name")]
        public string ApiName { get; set; }

        /// <summary>
        /// 敏感信息申请字段
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 敏感信息申请能力code值
        /// </summary>
        [JsonPropertyName("package_code")]
        public string PackageCode { get; set; }
    }
}
