using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassFileAddResponse.
    /// </summary>
    public class AlipayPassFileAddResponse : AlipayResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [JsonProperty("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否成功标识:T-成功；F-失败
        /// </summary>
        [JsonProperty("success")]
        public string Success { get; set; }
    }
}
