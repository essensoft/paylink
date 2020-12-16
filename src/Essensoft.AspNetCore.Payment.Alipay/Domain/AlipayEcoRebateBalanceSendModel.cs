using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRebateBalanceSendModel Data Structure.
    /// </summary>
    public class AlipayEcoRebateBalanceSendModel : AlipayObject
    {
        /// <summary>
        /// 用户订单明细
        /// </summary>
        [JsonPropertyName("items")]
        public List<RebateGood> Items { get; set; }

        /// <summary>
        /// 商户侧的用户订单id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
