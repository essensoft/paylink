using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceDataHotelServiceSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceDataHotelServiceSyncModel : AlipayObject
    {
        /// <summary>
        /// 酒店所在小程序的appid
        /// </summary>
        [JsonPropertyName("hotel_app_id")]
        public string HotelAppId { get; set; }

        /// <summary>
        /// 酒店信息
        /// </summary>
        [JsonPropertyName("hotel_info")]
        public HotelInfo HotelInfo { get; set; }

        /// <summary>
        /// [SERVICE_CREATE：服务创建 SERVICE_UPDATE：服务更新]  说明：值为SERVICE_CREATE时， 参数servic_id为空；值为SERVICE_UPDATE时， 参数servic_id必填
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 服务商侧酒店id
        /// </summary>
        [JsonPropertyName("outer_hotel_id")]
        public string OuterHotelId { get; set; }

        /// <summary>
        /// 提报服务的描述
        /// </summary>
        [JsonPropertyName("service_description")]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// 支付宝行业酒店服务的标识，第一次服务提报时为null， 更新服务提报时必传，和出参中service_id一致
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 提报服务名称，不要出现特殊字符，建议以 酒店名称+服务类型 组合作为服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务提报类型， 可选值 [HOTEL_RESERVATION : 酒店预订服务, HOTEL_CHECK_IN:酒店入住服务 ]
        /// </summary>
        [JsonPropertyName("service_submit_type")]
        public string ServiceSubmitType { get; set; }

        /// <summary>
        /// 服务提报url
        /// </summary>
        [JsonPropertyName("service_url")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// 服务商的标识， 需要支付宝技术配置。联调前请提前找技术人员配置
        /// </summary>
        [JsonPropertyName("source_system")]
        public string SourceSystem { get; set; }
    }
}
