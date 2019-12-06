using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicGisGetResponse.
    /// </summary>
    public class AlipayMobilePublicGisGetResponse : AlipayResponse
    {
        /// <summary>
        /// 精确度
        /// </summary>
        [JsonPropertyName("accuracy")]
        public string Accuracy { get; set; }

        /// <summary>
        /// 经纬度所在位置
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 纬度信息
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度信息
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }

        /// <summary>
        /// 经纬度对应位置所在的省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }
    }
}
