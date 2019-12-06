using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MachineInfo Data Structure.
    /// </summary>
    public class MachineInfo : AlipayObject
    {
        /// <summary>
        /// 设备数量
        /// </summary>
        [JsonPropertyName("machine_count")]
        public long MachineCount { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonPropertyName("machine_model")]
        public string MachineModel { get; set; }

        /// <summary>
        /// 设备类型，由商户定义
        /// </summary>
        [JsonPropertyName("machine_type")]
        public string MachineType { get; set; }
    }
}
