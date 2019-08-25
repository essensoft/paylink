using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeRefundApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeRefundApplyModel : AlipayObject
    {
        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定，格式为json格式。  医保退款场景下，DESIGNATED_REFUND_ASSET为INNER_ASSET表示只退自费部分，DESIGNATED_REFUND_ASSET为OUTSIDE_ASSET表示只退医保部分，医保部分不支持部分退。退医保资金必需传cancel_bill_no和cancel_serial_no。
        /// </summary>
        [JsonProperty("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 商户的操作员编号
        /// </summary>
        [JsonProperty("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔交易多次退款需要保证唯一，如需部分退款，则此参数必传。
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 订单支付时传入的商户订单号,不能和 trade_no同时为空
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款的原因说明
        /// </summary>
        [JsonProperty("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 商户的门店编号
        /// </summary>
        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 商户的终端编号
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 支付宝交易号，和商户订单号不能同时为空
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
