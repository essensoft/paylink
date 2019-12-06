using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataNearmallQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataNearmallQueryModel : AlipayObject
    {
        /// <summary>
        /// 说明来源
        /// </summary>
        [JsonPropertyName("app_channel")]
        public string AppChannel { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [JsonPropertyName("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 开始标记
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 数量标记
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 设备版本号
        /// </summary>
        [JsonPropertyName("product_version")]
        public string ProductVersion { get; set; }

        /// <summary>
        /// 半径，单位【米】
        /// </summary>
        [JsonPropertyName("radius")]
        public string Radius { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 地理位置经度
        /// </summary>
        [JsonPropertyName("x")]
        public long X { get; set; }

        /// <summary>
        /// 地理位置纬度
        /// </summary>
        [JsonPropertyName("y")]
        public long Y { get; set; }
    }
}
