using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiShopMallPageQueryModel Data Structure.
    /// </summary>
    public class KoubeiShopMallPageQueryModel : AlipayObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonProperty("mall_id")]
        public string MallId { get; set; }
    }
}
