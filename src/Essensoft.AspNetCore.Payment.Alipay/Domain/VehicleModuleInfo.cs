using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VehicleModuleInfo Data Structure.
    /// </summary>
    public class VehicleModuleInfo : AlipayObject
    {
        /// <summary>
        /// 车辆状态信息描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 车辆控制模块
        /// </summary>
        [JsonPropertyName("function")]
        public string Function { get; set; }

        /// <summary>
        /// 车辆模块状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
