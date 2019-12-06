using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantOrderRefundModel Data Structure.
    /// </summary>
    public class AlipayMerchantOrderRefundModel : AlipayObject
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

        /// <summary>
        /// 退款原因描述，可能是用户发起退款、或者是系统异常发起的回补退款
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款请求，比如下面的请求代表在这次退款中退2000家庭积分[{"request_no":"2019678438","amount":{"type":"FAMILY_POINT","amount":2000}}]。之所以是一个list是为了支持多笔退款，退款失败重试请不要更换request_no。单次全额退的request_no可以用out_biz_no
        /// </summary>
        [JsonPropertyName("refund_request")]
        public List<PaymentInformation> RefundRequest { get; set; }
    }
}
