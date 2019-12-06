using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedLocationInfo Data Structure.
    /// </summary>
    public class NewsfeedLocationInfo : AlipayObject
    {
        /// <summary>
        /// 地理信息
        /// </summary>
        [JsonPropertyName("ad_code")]
        public string AdCode { get; set; }

        /// <summary>
        /// 纬度 latitude（填写非0非1）
        /// </summary>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度 longitude（填写非0非1）
        /// </summary>
        [JsonPropertyName("lon")]
        public string Lon { get; set; }
    }
}
