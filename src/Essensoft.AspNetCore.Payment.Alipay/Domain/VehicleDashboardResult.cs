using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VehicleDashboardResult Data Structure.
    /// </summary>
    public class VehicleDashboardResult : AlipayObject
    {
        /// <summary>
        /// label每个元素对应的含义
        /// </summary>
        [JsonPropertyName("class_name")]
        public string ClassName { get; set; }

        /// <summary>
        /// 识别的labels
        /// </summary>
        [JsonPropertyName("label")]
        public long Label { get; set; }

        /// <summary>
        /// label每个元素对应的概率
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }
    }
}
