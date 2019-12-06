using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZmAuthParams Data Structure.
    /// </summary>
    public class ZmAuthParams : AlipayObject
    {
        /// <summary>
        /// 商户在芝麻端申请的appId
        /// </summary>
        [JsonPropertyName("buckle_app_id")]
        public string BuckleAppId { get; set; }

        /// <summary>
        /// 商户在芝麻端申请的merchantId
        /// </summary>
        [JsonPropertyName("buckle_merchant_id")]
        public string BuckleMerchantId { get; set; }
    }
}
