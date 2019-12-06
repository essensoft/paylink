using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherQueryModel : AlipayObject
    {
        /// <summary>
        /// 券ID(券唯一标识, 发券接口返回参数)
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
