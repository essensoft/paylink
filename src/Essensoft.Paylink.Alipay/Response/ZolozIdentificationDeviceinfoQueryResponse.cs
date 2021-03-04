using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
