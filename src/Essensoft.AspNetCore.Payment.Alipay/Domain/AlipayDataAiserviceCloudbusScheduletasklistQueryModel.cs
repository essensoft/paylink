using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletasklistQueryModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletasklistQueryModel : AlipayObject
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
        /// 公交公司id
        /// </summary>
        [JsonPropertyName("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 任务类型： 枚举： 0：客流接口  1： 时刻表接口 2：排班接口 3：轮班接口
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
