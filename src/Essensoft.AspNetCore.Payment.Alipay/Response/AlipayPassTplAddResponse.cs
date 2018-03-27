using Newtonsoft.Json;

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
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 接口调用返回结果信息
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// 操作成功标识【T：成功；F：失败】
        /// </summary>
        [JsonProperty("success")]
        public string Success { get; set; }
    }
}
