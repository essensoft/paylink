using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeRefundModel Data Structure.
    /// </summary>
    public class AlipayTradeRefundModel : AlipayObject
    {
        /// <summary>
        /// 退款包含的商品列表信息，Json格式。  其它说明详见：“商品明细说明”
        /// </summary>
        [JsonPropertyName("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商户的操作员编号
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要退款的交易所属收单机构的pid;
        /// </summary>
        [JsonPropertyName("org_pid")]
        public string OrgPid { get; set; }

        /// <summary>
        /// 标识一次退款请求，同一笔交易多次退款需要保证唯一，如需部分退款，则此参数必传。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 订单支付时传入的商户订单号,不能和 trade_no同时为空。
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 查询选项，商户通过上送该参数来定制同步需要额外返回的信息字段，数组格式。如：["refund_detail_item_list"]
        /// </summary>
        [JsonPropertyName("query_options")]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 订单退款币种信息
        /// </summary>
        [JsonPropertyName("refund_currency")]
        public string RefundCurrency { get; set; }

        /// <summary>
        /// 退款的原因说明
        /// </summary>
        [JsonPropertyName("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退分账明细信息
        /// </summary>
        [JsonPropertyName("refund_royalty_parameters")]
        public List<OpenApiRoyaltyDetailInfoPojo> RefundRoyaltyParameters { get; set; }

        /// <summary>
        /// 商户的门店编号
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 商户的终端编号
        /// </summary>
        [JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 支付宝交易号，和商户订单号不能同时为空
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
