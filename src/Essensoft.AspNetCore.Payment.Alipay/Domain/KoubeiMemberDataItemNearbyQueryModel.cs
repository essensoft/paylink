using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMemberDataItemNearbyQueryModel Data Structure.
    /// </summary>
    public class KoubeiMemberDataItemNearbyQueryModel : AlipayObject
    {
        /// <summary>
        /// 城市编码，国标码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public long Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public long Longitude { get; set; }

        /// <summary>
        /// 分页数量，一页为3个，限制在1-20之间
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页开始索引,即获取的页数,初始页为0,后续透传返回的next_start即可
        /// </summary>
        [JsonPropertyName("page_start")]
        public long PageStart { get; set; }

        /// <summary>
        /// 召回半径,单位为米,可以自行设置，向搜索请求时需要传入此参数获取附近商品
        /// </summary>
        [JsonPropertyName("radius")]
        public long Radius { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
