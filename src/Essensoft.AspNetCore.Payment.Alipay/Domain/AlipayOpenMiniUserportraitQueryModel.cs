using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniUserportraitQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniUserportraitQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户画像的时间范围。RECENT_7_DAY代表近7日，RECENT_30_DAY代表近30日
        /// </summary>
        [JsonPropertyName("date_scope")]
        public string DateScope { get; set; }

        /// <summary>
        /// 画像类型。AGE-年龄，PROVINCE-省份，CITY-城市，DEVICE-设备，GENDER-性别
        /// </summary>
        [JsonPropertyName("portrait_type")]
        public string PortraitType { get; set; }

        /// <summary>
        /// 用户类型。NEW_USER新用户，ACTIVE_USER活跃用户
        /// </summary>
        [JsonPropertyName("user_type")]
        public string UserType { get; set; }
    }
}
