using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayTradeQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayTradeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 买方信息
        /// </summary>
        [JsonPropertyName("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 1688买家ID
        /// </summary>
        [JsonPropertyName("buyer_scene_id")]
        public string BuyerSceneId { get; set; }

        /// <summary>
        /// 确认收货金额
        /// </summary>
        [JsonPropertyName("confirm_amt")]
        public string ConfirmAmt { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonPropertyName("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [JsonPropertyName("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退款金额，单位：分
        /// </summary>
        [JsonPropertyName("refund_amt")]
        public string RefundAmt { get; set; }

        /// <summary>
        /// 卖方信息
        /// </summary>
        [JsonPropertyName("seller")]
        public Member Seller { get; set; }

        /// <summary>
        /// 1688卖家ID
        /// </summary>
        [JsonPropertyName("seller_scene_id")]
        public string SellerSceneId { get; set; }

        /// <summary>
        /// 源订单ID，1688订单ID
        /// </summary>
        [JsonPropertyName("source_order_no")]
        public string SourceOrderNo { get; set; }

        /// <summary>
        /// 订单状态：VALID/INVALID/INIT/CANCEL
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 网商日志追踪ID
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 订单金额，单位：分
        /// </summary>
        [JsonPropertyName("trade_amt")]
        public string TradeAmt { get; set; }

        /// <summary>
        /// 内部订单号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
