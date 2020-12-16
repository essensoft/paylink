using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainTwcTradeinfoQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainTwcTradeinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付者用户的支付宝id
        /// </summary>
        [JsonPropertyName("buyeruid")]
        public string Buyeruid { get; set; }

        /// <summary>
        /// 卖家支付宝账户
        /// </summary>
        [JsonPropertyName("selleruid")]
        public string Selleruid { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonPropertyName("tradefee")]
        public string Tradefee { get; set; }

        /// <summary>
        /// 支付订单id
        /// </summary>
        [JsonPropertyName("tradeid")]
        public string Tradeid { get; set; }
    }
}
