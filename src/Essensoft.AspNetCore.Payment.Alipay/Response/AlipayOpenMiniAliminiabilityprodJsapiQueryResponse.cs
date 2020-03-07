using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAliminiabilityprodJsapiQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAliminiabilityprodJsapiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code_dto_list")]
        public List<ErrorCodeDTO> ErrorCodeDtoList { get; set; }

        /// <summary>
        /// 入参
        /// </summary>
        [JsonPropertyName("in_params")]
        public string InParams { get; set; }

        /// <summary>
        /// JSAPI基础参数
        /// </summary>
        [JsonPropertyName("js_api_base_dto")]
        public JsApiBaseDTO JsApiBaseDto { get; set; }

        /// <summary>
        /// 出参
        /// </summary>
        [JsonPropertyName("out_params")]
        public string OutParams { get; set; }
    }
}
