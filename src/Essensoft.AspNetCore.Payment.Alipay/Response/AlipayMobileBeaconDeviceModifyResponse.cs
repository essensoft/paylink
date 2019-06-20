using Newtonsoft.Json;

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
        [JsonProperty("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 操作结果说明
        /// </summary>
        [JsonProperty("msg")]
        public override string Msg { get; set; }
    }
}
