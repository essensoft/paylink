using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeIndustryLocationUploadModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeIndustryLocationUploadModel : AlipayObject
    {
        /// <summary>
        /// 业务场景,分时租赁平台:car_sharing_zhima,具体业务对应的业务场景请联系业务确认
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 是否可用，Y：可用，N不可用。
        /// </summary>
        [JsonPropertyName("can_use")]
        public string CanUse { get; set; }

        /// <summary>
        /// 扩展信息字段，格式:json，注意，如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码, 分时租赁共享汽车场景下必填
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 地址位置纬度，取值范围：纬度-90~90，中国地区经度范围：纬度3.86~53.55
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 点位地址
        /// </summary>
        [JsonPropertyName("location_address")]
        public string LocationAddress { get; set; }

        /// <summary>
        /// 点位编码，唯一标识一个点位,需要保证唯一
        /// </summary>
        [JsonPropertyName("location_code")]
        public string LocationCode { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [JsonPropertyName("location_name")]
        public string LocationName { get; set; }

        /// <summary>
        /// 地址位置经度，取值范围：经度-180~180，中国地区经度范围：73.66~135.05
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
