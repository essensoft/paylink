using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppFlowQualificationDetectResponse.
    /// </summary>
    public class AlipayEbppFlowQualificationDetectResponse : AlipayResponse
    {
        /// <summary>
        /// 子业务码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 子业务描述
        /// </summary>
        [JsonPropertyName("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 用户绑定的手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 返回用户的校验结果
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 校验资格描述
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
