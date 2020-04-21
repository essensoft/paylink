using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
        public override string Code { get; set; }

        /// <summary>
        /// 操作结果说明
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }
    }
}
