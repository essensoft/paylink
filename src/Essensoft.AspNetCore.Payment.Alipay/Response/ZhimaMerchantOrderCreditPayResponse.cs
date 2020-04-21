using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantOrderCreditPayResponse.
    /// </summary>
    public class ZhimaMerchantOrderCreditPayResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝生成的资金流水号，用于商户与支付宝进行对账，无支付行为时为空
        /// </summary>
        [JsonPropertyName("alipay_fund_order_no")]
        public string AlipayFundOrderNo { get; set; }

        /// <summary>
        /// 此字段来源于商户创建订单时传入的值，帮助商户定位订单来源
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 支付失败原因描述
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户传入的资金交易号，无支付行为时为空
        /// </summary>
        [JsonPropertyName("out_trans_no")]
        public string OutTransNo { get; set; }

        /// <summary>
        /// 本次处理支付金额，单位为元，精确到小数点后两位，无支付行为时为空
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付结果状态，包括：支付成功(PAY_SUCCESS)，支付失败(PAY_FAILED)，支付处理中(PAY_INPROGRESS)，无支付行为时为空
        /// </summary>
        [JsonPropertyName("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付处理时间，无支付行为时为空
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 芝麻订单号，最长32位
        /// </summary>
        [JsonPropertyName("zm_order_no")]
        public string ZmOrderNo { get; set; }
    }
}
