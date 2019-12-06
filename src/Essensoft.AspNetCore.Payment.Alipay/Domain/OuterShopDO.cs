using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OuterShopDO Data Structure.
    /// </summary>
    public class OuterShopDO : AlipayObject
    {
        /// <summary>
        /// 合作商户ID
        /// </summary>
        [JsonPropertyName("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 支付宝店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 合作商户类型 （mike、_2dFire）  iSV自己定义自己的类型，推荐使用自己的域名
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
