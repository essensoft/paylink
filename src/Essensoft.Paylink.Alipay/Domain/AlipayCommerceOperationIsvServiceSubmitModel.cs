using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIsvServiceSubmitModel Data Structure.
    /// </summary>
    public class AlipayCommerceOperationIsvServiceSubmitModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段，服务扩展字段，示例：key：service_levle，value：standard
        /// </summary>
        [JsonPropertyName("extra_info")]
        public List<ExtraInfo> ExtraInfo { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public CateringMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [JsonPropertyName("service_description")]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务状态（ServiceStatus枚举） SERVICE_CREATE：服务创建 SERVICE_UPDATE：服务更新 SERVICE_OFFLINE：服务下线
        /// </summary>
        [JsonPropertyName("service_status")]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// 服务子类型（ServiceSubType枚举） PICK_UP:自提 TAKE_AWAY:外卖
        /// </summary>
        [JsonPropertyName("service_sub_type")]
        public string ServiceSubType { get; set; }

        /// <summary>
        /// 服务类型（餐饮固定为CATERING，ServiceType枚举）
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
        public CateringStoreInfo StoreInfo { get; set; }
    }
}
