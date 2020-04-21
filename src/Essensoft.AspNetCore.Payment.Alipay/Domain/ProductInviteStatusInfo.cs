using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProductInviteStatusInfo Data Structure.
    /// </summary>
    public class ProductInviteStatusInfo : AlipayObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// NONE：未签约，表示还没有签约该产品 MERCHANT_AUDITING：审核中，已经有合约在审核中，请等待审核完成 MERCHANT_CONFIRM_SUCCESS：已生效，表示合约已经生效，不需要再签约了 MERCHANT_APPLY_ORDER_CANCELED：审核未通过
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
