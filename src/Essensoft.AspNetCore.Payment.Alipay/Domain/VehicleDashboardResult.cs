using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VehicleDashboardResult Data Structure.
    /// </summary>
    [Serializable]
    public class VehicleDashboardResult : AlipayObject
    {
        /// <summary>
        /// label每个元素对应的含义
        /// </summary>
        [JsonProperty("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 识别的labels
        /// </summary>
        [JsonProperty("label")]
        public long Label { get; set; }

        /// <summary>
        /// label每个元素对应的概率
        /// </summary>
        [JsonProperty("score")]
        public long Score { get; set; }
    }
}
