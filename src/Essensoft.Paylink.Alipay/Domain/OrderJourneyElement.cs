using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// OrderJourneyElement Data Structure.
    /// </summary>
    public class OrderJourneyElement : AlipayObject
    {
        /// <summary>
        /// 达到地信息
        /// </summary>
        [JsonPropertyName("arrival")]
        public JourneyLocation Arrival { get; set; }

        /// <summary>
        /// 出发地信息
        /// </summary>
        [JsonPropertyName("departure")]
        public JourneyLocation Departure { get; set; }

        /// <summary>
        /// 行程时长，单位为秒
        /// </summary>
        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// 结束时间（格式化）
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 结束时间描述（非结构化）
        /// </summary>
        [JsonPropertyName("end_time_desc")]
        public string EndTimeDesc { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 功能服务列表
        /// </summary>
        [JsonPropertyName("functional_services")]
        public List<FunctionalService> FunctionalServices { get; set; }

        /// <summary>
        /// 出行人
        /// </summary>
        [JsonPropertyName("passagers")]
        public List<UserInfomation> Passagers { get; set; }

        /// <summary>
        /// 服务变更信息
        /// </summary>
        [JsonPropertyName("service_change_info")]
        public JourneyServiceChangeInfo ServiceChangeInfo { get; set; }

        /// <summary>
        /// 服务提供方信息
        /// </summary>
        [JsonPropertyName("service_provider")]
        public JourneyMerchantInfo ServiceProvider { get; set; }

        /// <summary>
        /// 开始时间格式化
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 开始时间描述（非格式化）
        /// </summary>
        [JsonPropertyName("start_time_desc")]
        public string StartTimeDesc { get; set; }
    }
}
