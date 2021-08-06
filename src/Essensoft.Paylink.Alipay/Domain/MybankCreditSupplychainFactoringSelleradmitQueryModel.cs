using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSelleradmitQueryModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainFactoringSelleradmitQueryModel : AlipayObject
    {
        /// <summary>
        /// isv支付宝id
        /// </summary>
        [JsonPropertyName("buyer_alipay_id")]
        public string BuyerAlipayId { get; set; }

        /// <summary>
        /// 门店名单类型,该值由网商提供
        /// </summary>
        [JsonPropertyName("list_type")]
        public string ListType { get; set; }

        /// <summary>
        /// 销售产品码,该值由网商提供
        /// </summary>
        [JsonPropertyName("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 门店支付登录号
        /// </summary>
        [JsonPropertyName("seller_login_id")]
        public string SellerLoginId { get; set; }
    }
}
