using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityCreateResponse.
    /// </summary>
    public class AntMerchantExpandFrontcategorySecurityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 前台类目ID
        /// </summary>
        [JsonPropertyName("front_category_id")]
        public string FrontCategoryId { get; set; }
    }
}
