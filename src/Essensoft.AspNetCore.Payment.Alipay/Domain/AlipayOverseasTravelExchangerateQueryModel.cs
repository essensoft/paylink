using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelExchangerateQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelExchangerateQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户当前所在国家的国家码，ISO-3166标准三位数字国家码，currency、countryCode、longitude & latitude三者不能同时为空
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 货币代码，ISO标准alpha- 3币种代码，currency、countryCode、longitude & latitude三者不能同时为空
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 业务扩展参数,用于商户的特定业务信息的传递,json格式
        /// </summary>
        [JsonPropertyName("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 用户当前定位纬度，currency、countryCode、longitude & latitude三者不能同时为空
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 用户当前定位经度，currency、countryCode、longitude & latitude三者不能同时为空
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，唯一，如有该字段，可以获取该币种对应会员等级的汇率
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
