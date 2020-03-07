using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItapDeviceControlAction Data Structure.
    /// </summary>
    public class ItapDeviceControlAction : AlipayObject
    {
        /// <summary>
        /// 行为描述
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 定制控制参数
        /// </summary>
        [JsonPropertyName("params")]
        public string Params { get; set; }
    }
}
