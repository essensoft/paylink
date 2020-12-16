using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniCategoryQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniCategoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 是否过滤小程序不可用类目
        /// </summary>
        [JsonPropertyName("is_filter")]
        public bool IsFilter { get; set; }
    }
}
