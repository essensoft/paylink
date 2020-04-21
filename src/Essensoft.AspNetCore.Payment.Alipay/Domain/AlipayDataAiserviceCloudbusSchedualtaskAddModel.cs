using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtaskAddModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualtaskAddModel : AlipayObject
    {
        /// <summary>
        /// 接口版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

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
        /// 下行场站配车数
        /// </summary>
        [JsonPropertyName("down_bus_cnt")]
        public long DownBusCnt { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 排班任务
        /// </summary>
        [JsonPropertyName("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 排班
        /// </summary>
        [JsonPropertyName("time_table_pid")]
        public string TimeTablePid { get; set; }

        /// <summary>
        /// 上行场站配车数
        /// </summary>
        [JsonPropertyName("up_bus_cnt")]
        public long UpBusCnt { get; set; }
    }
}
