using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicMenuUserUpdateResponse.
    /// </summary>
    public class AlipayMobilePublicMenuUserUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonProperty("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonProperty("msg")]
        public new string Msg { get; set; }
    }
}
