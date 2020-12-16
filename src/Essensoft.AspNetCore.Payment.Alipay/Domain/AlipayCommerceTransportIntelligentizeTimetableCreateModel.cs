using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeTimetableCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeTimetableCreateModel : AlipayObject
    {
        /// <summary>
        /// 城市代码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交企业ID
        /// </summary>
        [JsonPropertyName("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路信息列表，单次请求只支持同一条线路，支持同时计算该线路的上行+下行
        /// </summary>
        [JsonPropertyName("line_info_list")]
        public List<TimeTableLineInfo> LineInfoList { get; set; }

        /// <summary>
        /// 请求ID，唯一标识一次请求，由调用方自行确保唯一性
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务任务名称
        /// </summary>
        [JsonPropertyName("service_task_name")]
        public string ServiceTaskName { get; set; }
    }
}
