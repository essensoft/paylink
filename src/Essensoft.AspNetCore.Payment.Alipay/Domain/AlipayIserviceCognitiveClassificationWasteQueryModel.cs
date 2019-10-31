using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveClassificationWasteQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveClassificationWasteQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [JsonProperty("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 图片url，或者文本
        /// </summary>
        [JsonProperty("cognition_content")]
        public string CognitionContent { get; set; }

        /// <summary>
        /// 垃圾识别类型
        /// </summary>
        [JsonProperty("cognition_type")]
        public string CognitionType { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 业务上游流量来源
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
