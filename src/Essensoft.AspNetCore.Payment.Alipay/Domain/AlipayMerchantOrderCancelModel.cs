using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantOrderCancelModel Data Structure.
    /// </summary>
    public class AlipayMerchantOrderCancelModel : AlipayObject
    {
        /// <summary>
        /// 业务场景，某些场景下操作的不是用户本身的订单，而是用户所在群体的订单的情况下，必传
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 下单时候的买家id
        /// </summary>
        [JsonPropertyName("buyer")]
        public UserIdentity Buyer { get; set; }

        /// <summary>
        /// 退款扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 下单并支付的时候返回的订单号，与外部请求号两者之间必须传一个
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 创建订单时传入的外部请求号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
