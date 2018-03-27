using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringTablelistQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringTablelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
