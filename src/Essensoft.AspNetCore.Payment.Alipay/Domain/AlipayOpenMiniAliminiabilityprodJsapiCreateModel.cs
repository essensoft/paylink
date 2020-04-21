using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAliminiabilityprodJsapiCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAliminiabilityprodJsapiCreateModel : AlipayObject
    {
        /// <summary>
        /// api基本参数
        /// </summary>
        [JsonPropertyName("api_base_request")]
        public JsApiBaseDTO ApiBaseRequest { get; set; }

        /// <summary>
        /// JsApi错误码
        /// </summary>
        [JsonPropertyName("api_error_code_request")]
        public List<ErrorCodeDTO> ApiErrorCodeRequest { get; set; }

        /// <summary>
        /// 入参列表
        /// </summary>
        [JsonPropertyName("in_param_requests")]
        public string InParamRequests { get; set; }

        /// <summary>
        /// 出参
        /// </summary>
        [JsonPropertyName("out_param_requests")]
        public string OutParamRequests { get; set; }
    }
}
