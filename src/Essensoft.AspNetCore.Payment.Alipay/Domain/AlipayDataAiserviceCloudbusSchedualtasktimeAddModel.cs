using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtasktimeAddModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualtasktimeAddModel : AlipayObject
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 客流预测任务id
        /// </summary>
        [JsonPropertyName("bus_od_pid")]
        public string BusOdPid { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交公司id
        /// </summary>
        [JsonPropertyName("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 时刻表线路信息
        /// </summary>
        [JsonPropertyName("line_info")]
        public List<InputScheduleTime> LineInfo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonPropertyName("task_name")]
        public string TaskName { get; set; }
    }
}
