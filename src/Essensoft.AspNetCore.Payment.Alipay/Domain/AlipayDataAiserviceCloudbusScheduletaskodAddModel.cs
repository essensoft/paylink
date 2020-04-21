using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskodAddModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskodAddModel : AlipayObject
    {
        /// <summary>
        /// 接口版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 城市码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 配制id
        /// </summary>
        [JsonPropertyName("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 公交公司id
        /// </summary>
        [JsonPropertyName("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 线路信息
        /// </summary>
        [JsonPropertyName("line_info")]
        public List<InputScheduleLine> LineInfo { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonPropertyName("task_name")]
        public string TaskName { get; set; }
    }
}
