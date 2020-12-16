using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRebateBalanceQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoRebateBalanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户侧唯一商品id，查询商品的返利信息
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
