using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelUserDeleteResponse.
    /// </summary>
    public class AlipayMobilePublicLabelUserDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonProperty("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonProperty("msg")]
        public new string Msg { get; set; }
    }
}
