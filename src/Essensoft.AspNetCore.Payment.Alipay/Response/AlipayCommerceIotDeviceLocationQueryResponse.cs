using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceLocationQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceLocationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 设备位置的获取时间,13位时间戳,精确到毫秒
        /// </summary>
        [JsonPropertyName("time")]
        public long Time { get; set; }
    }
}
