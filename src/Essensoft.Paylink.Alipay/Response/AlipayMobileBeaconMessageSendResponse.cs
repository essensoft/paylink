using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMobileBeaconMessageSendResponse.
    /// </summary>
    public class AlipayMobileBeaconMessageSendResponse : AlipayResponse
    {
        /// <summary>
        /// 操作返回码
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 操作提示文案
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }
    }
}
