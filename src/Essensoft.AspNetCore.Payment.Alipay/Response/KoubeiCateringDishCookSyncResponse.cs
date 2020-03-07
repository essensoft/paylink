using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishCookSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCookSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 操作后返回整个模型
        /// </summary>
        [JsonPropertyName("kb_dish_cook")]
        public KbdishCookInfo KbDishCook { get; set; }
    }
}
