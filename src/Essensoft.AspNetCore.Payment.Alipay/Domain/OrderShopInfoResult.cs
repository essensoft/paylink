using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderShopInfoResult Data Structure.
    /// </summary>
    public class OrderShopInfoResult : AlipayObject
    {
        /// <summary>
        /// 店铺地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 商户门店id 支持英文、数字的组合
        /// </summary>
        [JsonPropertyName("merchant_shop_id")]
        public string MerchantShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系电话-支持固话或手机号 仅支持数字、+、-
        /// </summary>
        [JsonPropertyName("phone_num")]
        public string PhoneNum { get; set; }
    }
}
