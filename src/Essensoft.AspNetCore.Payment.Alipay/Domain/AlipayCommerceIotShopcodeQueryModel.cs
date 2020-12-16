using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotShopcodeQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotShopcodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备绑定的商户pid，直连场景填写商户收单pid，间连场景填写smid绑定的pid
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 设备绑定的门店shopid
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
