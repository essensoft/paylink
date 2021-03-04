using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosDishBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringPosDishBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜谱中的菜品的列表
        /// </summary>
        [JsonPropertyName("cook_dish")]
        public PosCookDishQryModel CookDish { get; set; }
    }
}
