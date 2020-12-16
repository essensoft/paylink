using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCityserviceUserAppinfoQueryResponse.
    /// </summary>
    public class AlipayEcoCityserviceUserAppinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务类型或接口
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 业务返回结果上下文
        /// </summary>
        [JsonPropertyName("result_context")]
        public string ResultContext { get; set; }

        /// <summary>
        /// 业务返回错误
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
