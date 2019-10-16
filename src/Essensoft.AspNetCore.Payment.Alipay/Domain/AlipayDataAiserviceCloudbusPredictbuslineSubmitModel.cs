using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictbuslineSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusPredictbuslineSubmitModel : AlipayObject
    {
        /// <summary>
        /// 接口版本
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 公交线路版本号
        /// </summary>
        [JsonProperty("route_version")]
        public string RouteVersion { get; set; }

        /// <summary>
        /// 客流预测公交线路列表
        /// </summary>
        [JsonProperty("routes")]
        public List<CloudbusRoute> Routes { get; set; }

        /// <summary>
        /// 客流预测任务描述
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
