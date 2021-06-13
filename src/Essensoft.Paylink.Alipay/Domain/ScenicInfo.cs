using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ScenicInfo Data Structure.
    /// </summary>
    public class ScenicInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝景区详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 支付宝景区市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 支付宝景区纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 支付宝维护的景区等级
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 支付宝景区经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 支付宝景区省名称
        /// </summary>
        [JsonPropertyName("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 支付宝景区ID
        /// </summary>
        [JsonPropertyName("scenic_id")]
        public string ScenicId { get; set; }

        /// <summary>
        /// 支付宝景区名称
        /// </summary>
        [JsonPropertyName("scenic_name")]
        public string ScenicName { get; set; }

        /// <summary>
        /// 支付宝维护的景区电话，可能有多个电话号，以英文逗号分隔
        /// </summary>
        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }
    }
}
