using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileBeaconDeviceQueryResponse.
    /// </summary>
    public class AlipayMobileBeaconDeviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 蓝牙设备信息
        /// </summary>
        [JsonProperty("beacon_device_info")]
        public BeaconDeviceInfo BeaconDeviceInfo { get; set; }

        /// <summary>
        /// 操作返回码，200为成功
        /// </summary>
        [JsonProperty("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 请求处理结果
        /// </summary>
        [JsonProperty("msg")]
        public new string Msg { get; set; }
    }
}
