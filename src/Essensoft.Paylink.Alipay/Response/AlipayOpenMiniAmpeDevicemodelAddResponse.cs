using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicemodelAddResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDevicemodelAddResponse : AlipayResponse
    {
        /// <summary>
        /// 设备机型id
        /// </summary>
        [JsonPropertyName("device_model_id")]
        public long DeviceModelId { get; set; }
    }
}
