using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MachineInfo Data Structure.
    /// </summary>
    public class MachineInfo : AlipayObject
    {
        /// <summary>
        /// 设备数量
        /// </summary>
        [JsonProperty("machine_count")]
        public long MachineCount { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("machine_model")]
        public string MachineModel { get; set; }

        /// <summary>
        /// 设备类型，由商户定义
        /// </summary>
        [JsonProperty("machine_type")]
        public string MachineType { get; set; }
    }
}
