using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosStallerrorQueryResponse.
    /// </summary>
    public class KoubeiCateringPosStallerrorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 档口异常菜品集合模型
        /// </summary>
        [JsonPropertyName("error_dish_stall_entity")]
        public ErrorDishStallEntity ErrorDishStallEntity { get; set; }
    }
}
