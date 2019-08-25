using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApplyBusinessCity Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyBusinessCity : AlipayObject
    {
        /// <summary>
        /// 业务归属地区编码,精确到区县
        /// </summary>
        [JsonProperty("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 投保地区用户选择的层级
        /// </summary>
        [JsonProperty("city_level")]
        public string CityLevel { get; set; }
    }
}
