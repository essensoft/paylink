using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
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
        public new string Code { get; set; }

        /// <summary>
        /// 操作结果说明
        /// </summary>
        [JsonProperty("msg")]
        public new string Msg { get; set; }
    }
}
