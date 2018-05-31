using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.JDPay.Response
{
    public class JDPayDefrayPayResponse : JDPayResponse
    {
        /// <summary>
        /// 提交者会员号
        /// </summary>
        [JsonProperty("customer_no")]
        public string CustomerNo { get; set; }

        /// <summary>
        /// 响应时间
        /// </summary>
        [JsonProperty("response_datetime")]
        public string ResponseDatetime { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名数据
        /// </summary>
        [JsonProperty("sign_data")]
        public string SignData { get; set; }

        /// <summary>
        /// 响应编码
        /// </summary>
        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// 响应描述
        /// </summary>
        [JsonProperty("response_message")]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// 商户订单流水号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonProperty("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 订单交易金额
        /// </summary>
        [JsonProperty("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonProperty("trade_currency")]
        public string TradeCurrency { get; set; }

        /// <summary>
        /// 交易回传参数
        /// </summary>
        [JsonProperty("return_params")]
        public string ReturnParams { get; set; }
    }
}
