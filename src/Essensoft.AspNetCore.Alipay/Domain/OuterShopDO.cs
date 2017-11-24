using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// OuterShopDO Data Structure.
    /// </summary>
    public class OuterShopDO : AlipayObject
    {
        /// <summary>
        /// 合作商户ID
        /// </summary>
        [JsonProperty("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 支付宝店铺ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 合作商户类型 （mike、_2dFire）  iSV自己定义自己的类型，推荐使用自己的域名
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
