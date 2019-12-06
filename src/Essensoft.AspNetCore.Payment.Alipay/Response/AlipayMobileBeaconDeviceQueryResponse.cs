using System.Text.Json.Serialization;
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
        [JsonPropertyName("beacon_device_info")]
        public BeaconDeviceInfo BeaconDeviceInfo { get; set; }

        /// <summary>
        /// 操作返回码，200为成功
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 请求处理结果
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }
    }
}
