using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassTplAddResponse.
    /// </summary>
    public class AlipayPassTplAddResponse : AlipayResponse
    {
        /// <summary>
        /// 接口返回业务错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 接口调用返回结果信息
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 操作成功标识【T：成功；F：失败】
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
