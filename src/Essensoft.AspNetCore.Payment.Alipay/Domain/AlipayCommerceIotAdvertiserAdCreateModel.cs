using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdCreateModel : AlipayObject
    {
        /// <summary>
        /// 定向的设备sn列表
        /// </summary>
        [JsonPropertyName("device_sn_list")]
        public List<string> DeviceSnList { get; set; }

        /// <summary>
        /// 设备类型，qt:蜻蜓
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 投放结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 广告位值，静默页：idle
        /// </summary>
        [JsonPropertyName("event")]
        public string Event { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonPropertyName("material_id")]
        public long MaterialId { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [JsonPropertyName("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 投放开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
