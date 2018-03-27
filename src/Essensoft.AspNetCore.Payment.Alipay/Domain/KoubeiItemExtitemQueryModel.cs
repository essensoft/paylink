using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemExtitemQueryModel Data Structure.
    /// </summary>
    public class KoubeiItemExtitemQueryModel : AlipayObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonProperty("item_code")]
        public string ItemCode { get; set; }
    }
}
