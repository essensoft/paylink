using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosDishbatchDeleteResponse.
    /// </summary>
    public class KoubeiCateringPosDishbatchDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 删除成功的ID
        /// </summary>
        [JsonPropertyName("dish_ids")]
        public List<string> DishIds { get; set; }
    }
}
