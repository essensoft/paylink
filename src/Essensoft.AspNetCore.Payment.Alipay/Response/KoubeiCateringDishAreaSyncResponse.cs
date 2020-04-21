using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishAreaSyncResponse.
    /// </summary>
    public class KoubeiCateringDishAreaSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 餐区餐台模型
        /// </summary>
        [JsonPropertyName("kb_dish_area")]
        public KbdishAreaInfo KbDishArea { get; set; }
    }
}
