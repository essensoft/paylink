using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppCommunityOwnercardmsgSyncResponse.
    /// </summary>
    public class AlipayEbppCommunityOwnercardmsgSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝消息id
        /// </summary>
        [JsonPropertyName("alipay_msg_id")]
        public string AlipayMsgId { get; set; }
    }
}
