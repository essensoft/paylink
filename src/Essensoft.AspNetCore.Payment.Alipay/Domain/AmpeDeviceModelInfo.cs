using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AmpeDeviceModelInfo Data Structure.
    /// </summary>
    public class AmpeDeviceModelInfo : AlipayObject
    {
        /// <summary>
        /// 硬件参数
        /// </summary>
        [JsonPropertyName("hardware_params")]
        public string HardwareParams { get; set; }

        /// <summary>
        /// 机型id
        /// </summary>
        [JsonPropertyName("model_id")]
        public long ModelId { get; set; }

        /// <summary>
        /// 机型名称
        /// </summary>
        [JsonPropertyName("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 机型编号
        /// </summary>
        [JsonPropertyName("model_no")]
        public string ModelNo { get; set; }
    }
}
