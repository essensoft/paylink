using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategorySyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishVirtualcategorySyncModel : AlipayObject
    {
        /// <summary>
        /// 类目信息
        /// </summary>
        [JsonPropertyName("catetory_info")]
        public KbdishVirtualCatetorySimplifyInfo CatetoryInfo { get; set; }
    }
}
