using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringCommodityOrderBuyModel Data Structure.
    /// </summary>
    public class KoubeiCateringCommodityOrderBuyModel : AlipayObject
    {
        /// <summary>
        /// 订购服务时订购人id(订购人是操作员的时候，agent_Id为操作员个人Id)
        /// </summary>
        [JsonPropertyName("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// merchant:表示订购人是商户，此时agentId和consumerCardNo是同一个;  operator: 表示订购人是操作员，此时agentId为操作员id，consumerCardNo是该操作员对应的主账户
        /// </summary>
        [JsonPropertyName("agent_type")]
        public string AgentType { get; set; }

        /// <summary>
        /// 订购服务时订购人的主账户
        /// </summary>
        [JsonPropertyName("consumer_card_no")]
        public string ConsumerCardNo { get; set; }

        /// <summary>
        /// 订购的服务ID
        /// </summary>
        [JsonPropertyName("merchandise_id")]
        public string MerchandiseId { get; set; }

        /// <summary>
        /// 需要订购插件的门店集合；不传是不订购任何门店，order_result返回false
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
