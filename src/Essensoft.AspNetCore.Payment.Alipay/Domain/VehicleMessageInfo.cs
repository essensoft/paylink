using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VehicleMessageInfo Data Structure.
    /// </summary>
    public class VehicleMessageInfo : AlipayObject
    {
        /// <summary>
        /// vehicle_cond_infos 是车况信息列表,包含VehicleConditionInfo子类型(比如电频,电压,里程等信息)
        /// </summary>
        [JsonPropertyName("vehicle_cond_infos")]
        public List<VehicleConditionInfo> VehicleCondInfos { get; set; }

        /// <summary>
        /// vehicle_module_infos是车辆模组信息列表,包含VehicleModuleInfo子类型(比如引擎、车门、后备箱等信息)
        /// </summary>
        [JsonPropertyName("vehicle_module_infos")]
        public List<VehicleModuleInfo> VehicleModuleInfos { get; set; }
    }
}
