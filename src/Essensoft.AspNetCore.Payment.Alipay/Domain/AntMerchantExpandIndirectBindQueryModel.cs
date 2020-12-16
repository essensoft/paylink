using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectBindQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIndirectBindQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// smid传入后，传入的partner_id无效 smid和partner_id二选一必填
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}
