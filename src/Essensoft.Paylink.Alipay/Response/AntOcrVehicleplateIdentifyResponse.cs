using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntOcrVehicleplateIdentifyResponse.
    /// </summary>
    public class AntOcrVehicleplateIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
