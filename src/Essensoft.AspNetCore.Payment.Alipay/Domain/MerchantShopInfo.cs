using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantShopInfo Data Structure.
    /// </summary>
    public class MerchantShopInfo : AlipayObject
    {
        /// <summary>
        /// 审核驳回原因
        /// </summary>
        [JsonPropertyName("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 商家的pid
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商家门店编码，可自定义，但必须唯一
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }

        /// <summary>
        /// 门店状态，AUDITING:审核中，AUDIT_REJECT:审核驳回，VALID:已生效，UPDATING:更新中，INVALID:已失效
        /// </summary>
        [JsonPropertyName("shop_status")]
        public string ShopStatus { get; set; }
    }
}
