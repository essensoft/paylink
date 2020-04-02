using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeCreditFinancePayModel Data Structure.
    /// </summary>
    public class AlipayTradeCreditFinancePayModel : AlipayObject
    {
        /// <summary>
        /// 本次需要支付的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 本次金融支付对应的业务类型,本次对应： BILL_REPAY:账单还款后打款
        /// </summary>
        [JsonPropertyName("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 币种，CNY
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 扩展参数，json结构体，具体值需要联系支付宝工程师确认
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 外部请求号，用于控制幂等
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 收款人信息
        /// </summary>
        [JsonPropertyName("payee_info")]
        public CreditFinancePayAccountInfo PayeeInfo { get; set; }

        /// <summary>
        /// 本次支付的付款人信息
        /// </summary>
        [JsonPropertyName("payer_info")]
        public CreditFinancePayAccountInfo PayerInfo { get; set; }

        /// <summary>
        /// 本次支付的描述
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 需要进行金融支付处理的交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
