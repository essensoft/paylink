using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseBcgroupJoinedConsultModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseBcgroupJoinedConsultModel : AlipayObject
    {
        /// <summary>
        /// 商家/分组维度的业务标识ID
        /// </summary>
        [JsonPropertyName("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// BC客户群租户ID，找产品/技术同学咨询业务所对应的租户ID
        /// </summary>
        [JsonPropertyName("tenant_id")]
        public long TenantId { get; set; }

        /// <summary>
        /// 支付宝用户的唯一标识，以2088开头的16位数字。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
