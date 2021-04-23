using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMobileBeaconDeviceModifyResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回的操作码
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 操作结果说明
        /// </summary>
        [JsonPropertyName("msg")]
        public new string Msg { get; set; }
    }
}
