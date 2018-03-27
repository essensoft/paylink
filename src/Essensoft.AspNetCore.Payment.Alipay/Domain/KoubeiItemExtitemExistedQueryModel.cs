using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("code_list")]
        public List<string> CodeList { get; set; }
    }
}
