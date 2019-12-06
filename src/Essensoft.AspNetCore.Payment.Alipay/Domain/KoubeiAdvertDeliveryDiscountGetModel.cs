using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountGetModel Data Structure.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountGetModel : AlipayObject
    {
        /// <summary>
        /// 媒体编号，使用前需要找业务申请 ，不申请直接调用会失败
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市编码，国标码，比如310100是上海
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 纬度，以高德地图为准， 小数点后保留六位
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，以高德地图为准， 小数点后保留六位
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 被推荐用户的手机号码，不能与user_id同时存在
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝口碑门店ID  如果提供门店ID，则优先查询门店下发的券。
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 获取推荐广告列表个数，值小于等于100个
        /// </summary>
        [JsonPropertyName("size")]
        public string Size { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，以2088开头的16位数字
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
