using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicMessagePushResponse.
    /// </summary>
    public class AlipayMobilePublicMessagePushResponse : AlipayResponse
    {
        /// <summary>
        /// 成功
        /// </summary>
        [JsonProperty("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [JsonProperty("msg")]
        public override string Msg { get; set; }
    }
}
