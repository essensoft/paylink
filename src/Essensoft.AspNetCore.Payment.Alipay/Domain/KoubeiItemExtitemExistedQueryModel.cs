using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemExtitemExistedQueryModel Data Structure.
    /// </summary>
    public class KoubeiItemExtitemExistedQueryModel : AlipayObject
    {
        /// <summary>
        /// 商品编码列表, 商品编码数量不超过100条。
        /// </summary>
        [JsonPropertyName("code_list")]
        public List<string> CodeList { get; set; }
    }
}
