using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HotelInfo Data Structure.
    /// </summary>
    public class HotelInfo : AlipayObject
    {
        /// <summary>
        /// 酒店品牌
        /// </summary>
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 酒店地址
        /// </summary>
        [JsonPropertyName("hotel_address")]
        public string HotelAddress { get; set; }

        /// <summary>
        /// 酒店可以入住时间
        /// </summary>
        [JsonPropertyName("hotel_check_in_time")]
        public string HotelCheckInTime { get; set; }

        /// <summary>
        /// 酒店离店时间
        /// </summary>
        [JsonPropertyName("hotel_check_out_time")]
        public string HotelCheckOutTime { get; set; }

        /// <summary>
        /// 酒店名称
        /// </summary>
        [JsonPropertyName("hotel_name")]
        public string HotelName { get; set; }

        /// <summary>
        /// 高德坐标系下的纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 高德坐标系下的经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 身份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }
    }
}
