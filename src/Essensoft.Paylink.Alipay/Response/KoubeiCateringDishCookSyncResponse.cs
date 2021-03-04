using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
