using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandFrontcategorySecurityDeleteModel : AlipayObject
    {
        /// <summary>
        /// 前台类目ID
        /// </summary>
        [JsonProperty("front_category_id")]
        public string FrontCategoryId { get; set; }
    }
}
