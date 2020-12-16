using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantBrandListResult Data Structure.
    /// </summary>
    public class MerchantBrandListResult : AlipayObject
    {
        /// <summary>
        /// 商户已有品牌
        /// </summary>
        [JsonPropertyName("brand_list_result")]
        public List<BrandResult> BrandListResult { get; set; }
    }
}
