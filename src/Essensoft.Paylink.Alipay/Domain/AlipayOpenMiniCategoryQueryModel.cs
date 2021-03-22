using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniCategoryQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniCategoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 是否过滤小程序不可用类目。枚举值如下： * true：表示过滤不可用类目。 * false：表示不过滤不可用类目。
        /// </summary>
        [JsonPropertyName("is_filter")]
        public bool IsFilter { get; set; }
    }
}
