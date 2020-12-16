using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniappBrandAuditResult Data Structure.
    /// </summary>
    public class MiniappBrandAuditResult : AlipayObject
    {
        /// <summary>
        /// 小程序提交品牌认证时的品牌id
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 小程序提交品牌认证时的品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 小程序提交品牌认证后的认证状态 AUDITING(审核中) AUDIT_PASS(审核通过) AUDIT_REJECT(驳回审核) INVALID(已失效) NEAR_INVALID(即将过期失效) CANCEL(取消认证) NO_BRAND(未认证)
        /// </summary>
        [JsonPropertyName("brand_status")]
        public string BrandStatus { get; set; }

        /// <summary>
        /// 小程序提交品牌认证是否认证成功
        /// </summary>
        [JsonPropertyName("has_brand")]
        public string HasBrand { get; set; }

        /// <summary>
        /// 失效原因
        /// </summary>
        [JsonPropertyName("invalid_reason")]
        public string InvalidReason { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }
    }
}
