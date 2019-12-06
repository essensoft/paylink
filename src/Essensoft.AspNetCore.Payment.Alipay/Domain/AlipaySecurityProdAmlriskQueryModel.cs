using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdAmlriskQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdAmlriskQueryModel : AlipayObject
    {
        /// <summary>
        /// 办公地址
        /// </summary>
        [JsonPropertyName("business_address")]
        public string BusinessAddress { get; set; }

        /// <summary>
        /// 标识该次反洗钱风险分析事件请求的id，商户应保证此id唯一。
        /// </summary>
        [JsonPropertyName("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 与商户相关个体的信息列表，可以有0个到多个。
        /// </summary>
        [JsonPropertyName("individual_list")]
        public List<IndividualInfo> IndividualList { get; set; }

        /// <summary>
        /// 公司名称、类型、性质
        /// </summary>
        [JsonPropertyName("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 该商户准入申请的id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 公司注册地址
        /// </summary>
        [JsonPropertyName("registered_address")]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// 公司注册号
        /// </summary>
        [JsonPropertyName("registration_number")]
        public string RegistrationNumber { get; set; }
    }
}
