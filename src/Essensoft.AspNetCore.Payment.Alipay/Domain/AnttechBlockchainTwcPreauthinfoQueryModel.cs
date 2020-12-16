using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainTwcPreauthinfoQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainTwcPreauthinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 预授权码
        /// </summary>
        [JsonPropertyName("authno")]
        public string Authno { get; set; }

        /// <summary>
        /// 付款者支付宝账户
        /// </summary>
        [JsonPropertyName("buyeruid")]
        public string Buyeruid { get; set; }

        /// <summary>
        /// 收款者支付宝账号uid
        /// </summary>
        [JsonPropertyName("selleruid")]
        public string Selleruid { get; set; }

        /// <summary>
        /// 预授权金额
        /// </summary>
        [JsonPropertyName("totalamount")]
        public string Totalamount { get; set; }
    }
}
