using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingExchangevoucherUseModel Data Structure.
    /// </summary>
    public class AlipayMarketingExchangevoucherUseModel : AlipayObject
    {
        /// <summary>
        /// 外部业务号，用户幂等控制。相同voucher_id和out_biz_no被认为是同一次核销
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户ID ，必须保证待使用的券ID归属于该支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 待使用的券id ，来自发券接口alipay.marketing.voucher.send
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
