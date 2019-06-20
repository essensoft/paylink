using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicMessageLabelSendResponse.
    /// </summary>
    public class AlipayMobilePublicMessageLabelSendResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonProperty("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonProperty("msg")]
        public override string Msg { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonProperty("msg_id")]
        public string MsgId { get; set; }
    }
}
