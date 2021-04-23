using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRebateBalanceQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoRebateBalanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户侧唯一商品id，查询该商品的返利信息。
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用户支付宝唯一标识，2088开头。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
