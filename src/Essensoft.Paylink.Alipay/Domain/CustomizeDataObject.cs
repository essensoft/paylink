using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CustomizeDataObject Data Structure.
    /// </summary>
    public class CustomizeDataObject : AlipayObject
    {
        /// <summary>
        /// 商业中台产品实例ID
        /// </summary>
        [JsonPropertyName("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 商业中台产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商业中台租户企业名称
        /// </summary>
        [JsonPropertyName("tenant_company_name")]
        public string TenantCompanyName { get; set; }

        /// <summary>
        /// 商业中台租户ID
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public string TenantId { get; set; }
    }
}
