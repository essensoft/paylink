using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarFuellingShopCreateResponse.
    /// </summary>
    public class AlipayEcoMycarFuellingShopCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 车主平台内部门店编号,系统唯一，ISV应保存好该标识
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
