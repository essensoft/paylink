using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityDeleteModel Data Structure.
    /// </summary>
    public class AntMerchantExpandFrontcategorySecurityDeleteModel : AlipayObject
    {
        /// <summary>
        /// 前台类目ID
        /// </summary>
        [JsonPropertyName("front_category_id")]
        public string FrontCategoryId { get; set; }
    }
}
