using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualconfigSetModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualconfigSetModel : AlipayObject
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
        /// 配制名称
        /// </summary>
        [JsonPropertyName("config_name")]
        public string ConfigName { get; set; }

        /// <summary>
        /// 公交公司id
        /// </summary>
        [JsonPropertyName("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 日期列表
        /// </summary>
        [JsonPropertyName("date")]
        public List<string> Date { get; set; }
    }
}
