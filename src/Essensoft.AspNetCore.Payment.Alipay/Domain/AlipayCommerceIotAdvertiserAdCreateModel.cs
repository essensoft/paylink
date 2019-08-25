using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserAdCreateModel : AlipayObject
    {
        /// <summary>
        /// 定向的设备sn列表
        /// </summary>
        [JsonProperty("device_sn_list")]
        public List<string> DeviceSnList { get; set; }

        /// <summary>
        /// 设备类型，qt:蜻蜓
        /// </summary>
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 投放结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 广告位值，静默页：idle
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// 物料id
        /// </summary>
        [JsonProperty("material_id")]
        public long MaterialId { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 投放开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }
    }
}
