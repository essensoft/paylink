using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantCreditserviceDetailModifyModel Data Structure.
    /// </summary>
    public class ZhimaMerchantCreditserviceDetailModifyModel : AlipayObject
    {
        /// <summary>
        /// 信用服务基础信息配置，为必传字段。此字段为复杂模型，其中服务名称和服务logo为必传属性。
        /// </summary>
        [JsonPropertyName("base_info_config")]
        public BaseInfoConfig BaseInfoConfig { get; set; }

        /// <summary>
        /// 信用服务ID，通过<a href="https://opendocs.alipay.com/apis/api_8/zhima.merchant.creditservice.detail.create">zhima.merchant.creditservice.detail.create</a>(芝麻信用信用服务创建)接口创建信用服务后获取。
        /// </summary>
        [JsonPropertyName("credit_service_id")]
        public string CreditServiceId { get; set; }

        /// <summary>
        /// 修改信用服务版本扩展字段，为JSON字符串。
        /// </summary>
        [JsonPropertyName("extra_info")]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// 信用服务守护配置，为必传字段。此字段为复杂模型，其中商户服务电话为必传属性
        /// </summary>
        [JsonPropertyName("promise_config")]
        public PromiseConfig PromiseConfig { get; set; }

        /// <summary>
        /// 信用服务风控配置，为必传字段。此字段为复杂模型，其中类目code为必传属性。
        /// </summary>
        [JsonPropertyName("risk_config")]
        public RiskConfig RiskConfig { get; set; }
    }
}
