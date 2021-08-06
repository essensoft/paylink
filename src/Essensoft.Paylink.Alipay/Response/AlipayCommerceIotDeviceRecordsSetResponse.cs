using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceRecordsSetResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceRecordsSetResponse : AlipayResponse
    {
        /// <summary>
        /// 设备档案
        /// </summary>
        [JsonPropertyName("device_records")]
        public DeviceRecords DeviceRecords { get; set; }
    }
}
