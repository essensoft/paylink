using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderPayModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeNormalpayOrderPayModel : AlipayObject
    {
        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 扩展参数，内容是JSON格式，并用urlconde编码，按场景约定具体字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 操作场景类型 ：NORMAL_PAY_PAYMENT_WITH_CREDIT-周卡支付;NORMAL_PAY_PAYMENT_WITH_GUARANTEE-担保支付；不传默认为周卡支付；
        /// </summary>
        [JsonPropertyName("operate_scene_type")]
        public string OperateSceneType { get; set; }

        /// <summary>
        /// 创建订单时返回的订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 创建订单的订单类型
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 收方资产信息，内容是JSON格式，并用urlencode编码，按场景约定具体字段
        /// </summary>
        [JsonPropertyName("payee_fund_detail")]
        public string PayeeFundDetail { get; set; }

        /// <summary>
        /// 付方资产信息，内容是JSON格式，并用urlencode编码，按场景约定具体字段
        /// </summary>
        [JsonPropertyName("payer_fund_detail")]
        public string PayerFundDetail { get; set; }

        /// <summary>
        /// 支付备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求流水号，表示外部一次请求，幂等字段
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 请求时间，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("request_time")]
        public string RequestTime { get; set; }
    }
}
