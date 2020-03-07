using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationDeviceinfoQueryResponse.
    /// </summary>
    public class ZolozIdentificationDeviceinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// device_info
        /// </summary>
        [JsonPropertyName("device_info")]
        public ZolozDeviceInfo DeviceInfo { get; set; }
    }
}
