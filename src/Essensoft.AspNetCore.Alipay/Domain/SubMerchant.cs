using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// SubMerchant Data Structure.
    /// </summary>
    public class SubMerchant : AlipayObject
    {
        /// <summary>
        /// 二级商户的支付宝id
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }
    }
}
