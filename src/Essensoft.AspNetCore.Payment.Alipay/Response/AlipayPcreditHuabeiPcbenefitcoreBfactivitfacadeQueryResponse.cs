using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcbenefitcoreBfactivitfacadeQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcbenefitcoreBfactivitfacadeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 错误信息，参考通用错误格式
        /// </summary>
        [JsonPropertyName("error_context")]
        public List<string> ErrorContext { get; set; }

        /// <summary>
        /// 花呗营销活动信息返回数据
        /// </summary>
        [JsonPropertyName("result")]
        public BFActivityOpenApiResult Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
