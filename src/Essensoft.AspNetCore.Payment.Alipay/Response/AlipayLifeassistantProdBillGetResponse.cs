using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayLifeassistantProdBillGetResponse.
    /// </summary>
    public class AlipayLifeassistantProdBillGetResponse : AlipayResponse
    {
        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付款项名称
        /// </summary>
        [JsonPropertyName("order_item")]
        public string OrderItem { get; set; }

        /// <summary>
        /// 支付时间，毫秒
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 付款类型
        /// </summary>
        [JsonPropertyName("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 收款方名称|机构名称
        /// </summary>
        [JsonPropertyName("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 交易类型  S——担保交易  FP——即时到帐  COD——货到付款
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }
    }
}
