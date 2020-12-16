using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeviceRelationData Data Structure.
    /// </summary>
    public class DeviceRelationData : AlipayObject
    {
        /// <summary>
        /// 生效计划id列表
        /// </summary>
        [JsonPropertyName("plan_id_list")]
        public List<long> PlanIdList { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [JsonPropertyName("sn")]
        public string Sn { get; set; }
    }
}
