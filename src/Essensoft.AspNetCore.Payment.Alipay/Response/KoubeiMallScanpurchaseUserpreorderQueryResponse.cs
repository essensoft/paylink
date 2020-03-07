using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMallScanpurchaseUserpreorderQueryResponse.
    /// </summary>
    public class KoubeiMallScanpurchaseUserpreorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 预订单信息
        /// </summary>
        [JsonPropertyName("advance_order")]
        public AdvanceOrder AdvanceOrder { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 商圈是否开通会员系统
        /// </summary>
        [JsonPropertyName("mall_has_card")]
        public bool MallHasCard { get; set; }

        /// <summary>
        /// 用户是否开通会员卡
        /// </summary>
        [JsonPropertyName("open_card")]
        public bool OpenCard { get; set; }

        /// <summary>
        /// 开通会员卡地址
        /// </summary>
        [JsonPropertyName("open_card_url")]
        public string OpenCardUrl { get; set; }

        /// <summary>
        /// 口碑交易订单ID。只有在用户真实下单才会有。
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态，包含：（初始化：INIT，待付款：WAIT_PAY,  付款成功：PAID，关闭状态：CLOSE）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
