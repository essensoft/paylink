using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OperateContext Data Structure.
    /// </summary>
    public class OperateContext : AlipayObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 操作者id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作者类型，PROVIDER:服务商,PROVIDER_STAFF:服务商员工,MER:商户,MER_STAFF:商户员工,SALES:阿里销售小二,SYSTEM:系统
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }
    }
}
