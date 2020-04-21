using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
        public override string Code { get; set; }

        /// <summary>
        /// 操作提示文案
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }
    }
}
