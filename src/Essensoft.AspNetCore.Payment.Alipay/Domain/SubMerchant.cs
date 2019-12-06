using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubMerchant Data Structure.
    /// </summary>
    public class SubMerchant : AlipayObject
    {
        /// <summary>
        /// 间连受理商户的支付宝商户编号，通过间连商户入驻后得到。间连业务下必传，并且需要按规范传递受理商户编号。
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户id类型，
        /// </summary>
        [JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; }
    }
}
