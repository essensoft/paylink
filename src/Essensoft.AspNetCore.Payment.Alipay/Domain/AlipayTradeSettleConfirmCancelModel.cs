using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeSettleConfirmCancelModel Data Structure.
    /// </summary>
    public class AlipayTradeSettleConfirmCancelModel : AlipayObject
    {
        /// <summary>
        /// 原始确认结算时的请求号，对应于需要撤销的那笔请求
        /// </summary>
        [JsonPropertyName("ori_request_no")]
        public string OriRequestNo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
