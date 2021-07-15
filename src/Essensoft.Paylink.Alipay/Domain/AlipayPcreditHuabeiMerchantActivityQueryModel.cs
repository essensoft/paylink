using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantActivityQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantActivityQueryModel : AlipayObject
    {
        /// <summary>
        /// 模版ID
        /// </summary>
        [JsonPropertyName("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// MERCHANT_INTEREST_SUBSIDY_MIXED 代表新活动，模版ID以mixed开头；其他为 MERCHANT_INTEREST_SUBSIDY_THIRDPARTY 代表老活动
        /// </summary>
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }
    }
}
