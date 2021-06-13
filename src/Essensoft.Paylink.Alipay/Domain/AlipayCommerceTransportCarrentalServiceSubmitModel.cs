using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportCarrentalServiceSubmitModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportCarrentalServiceSubmitModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段，服务扩展字段，示例：key：service_sub_type，value：car_rental_day
        /// </summary>
        [JsonPropertyName("extra_info")]
        public List<ExtraInfo> ExtraInfo { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public CarRentalMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 服务动作  SERVICE_CREATE：服务创建  SERVICE_UPDATE：服务更新
        /// </summary>
        [JsonPropertyName("service_action")]
        public string ServiceAction { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [JsonPropertyName("service_description")]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// 描述服务名称(不可重复)
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 租车固定为CAR_RENTAL
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务url（可直接跳转对应的服务子类型小程序页面）
        /// </summary>
        [JsonPropertyName("service_url")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [JsonPropertyName("store_info")]
        public CarRentalStoreInfo StoreInfo { get; set; }
    }
}
