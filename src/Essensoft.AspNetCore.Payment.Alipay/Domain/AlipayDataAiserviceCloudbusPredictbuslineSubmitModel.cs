using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictbuslineSubmitModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictbuslineSubmitModel : AlipayObject
    {
        /// <summary>
        /// 接口版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 公交线路版本号
        /// </summary>
        [JsonPropertyName("route_version")]
        public string RouteVersion { get; set; }

        /// <summary>
        /// 客流预测公交线路列表
        /// </summary>
        [JsonPropertyName("routes")]
        public List<CloudbusRoute> Routes { get; set; }

        /// <summary>
        /// 客流预测任务描述
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
