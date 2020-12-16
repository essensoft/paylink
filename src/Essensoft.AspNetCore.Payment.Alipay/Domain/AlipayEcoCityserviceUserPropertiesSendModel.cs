using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceUserPropertiesSendModel Data Structure.
    /// </summary>
    public class AlipayEcoCityserviceUserPropertiesSendModel : AlipayObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 数据同步类型
        /// </summary>
        [JsonPropertyName("cud_type")]
        public string CudType { get; set; }

        /// <summary>
        /// 行业类型
        /// </summary>
        [JsonPropertyName("industry_type")]
        public string IndustryType { get; set; }

        /// <summary>
        /// 用户属性类型
        /// </summary>
        [JsonPropertyName("prop_type")]
        public string PropType { get; set; }

        /// <summary>
        /// 用户属性值
        /// </summary>
        [JsonPropertyName("prop_value")]
        public string PropValue { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
