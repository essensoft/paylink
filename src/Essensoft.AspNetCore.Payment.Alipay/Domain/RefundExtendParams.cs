using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundExtendParams Data Structure.
    /// </summary>
    public class RefundExtendParams : AlipayObject
    {
        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        [JsonPropertyName("credit_category_id")]
        public string CreditCategoryId { get; set; }

        /// <summary>
        /// 信用服务ID
        /// </summary>
        [JsonPropertyName("credit_service_id")]
        public string CreditServiceId { get; set; }
    }
}
