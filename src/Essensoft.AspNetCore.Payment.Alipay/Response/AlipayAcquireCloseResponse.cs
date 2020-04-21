using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAcquireCloseResponse.
    /// </summary>
    public class AlipayAcquireCloseResponse : AlipayResponse
    {
        /// <summary>
        /// 对返回响应码进行原因说明  当result_code响应码为SUCCESS时，不返回该参数
        /// </summary>
        [JsonPropertyName("detail_error_code")]
        public string DetailErrorCode { get; set; }

        /// <summary>
        /// 对详细错误码进行文字说明  当result_code响应码为SUCCESS时，不返回该参数
        /// </summary>
        [JsonPropertyName("detail_error_des")]
        public string DetailErrorDes { get; set; }

        /// <summary>
        /// 请求是否成功。请求成功不代表业务处理成功。  T代表成功  F代表失败
        /// </summary>
        [JsonPropertyName("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 对应商户网站的订单系统中的唯一订单号，非支付宝交易号。  需保证在商户网站中的唯一性。是请求时对应的参数，原样返回
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 关闭处理结果响应码。  SUCCESS：关闭成功  NKNOWN：结果未知
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。  最短16位，最长64位
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
