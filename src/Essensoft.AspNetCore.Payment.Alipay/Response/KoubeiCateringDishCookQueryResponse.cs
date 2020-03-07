using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishCookQueryResponse.
    /// </summary>
    public class KoubeiCateringDishCookQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜谱list
        /// </summary>
        [JsonPropertyName("kb_cook_list")]
        public List<KbdishCookInfo> KbCookList { get; set; }
    }
}
