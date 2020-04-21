using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAcquirePrecreateResponse.
    /// </summary>
    public class AlipayAcquirePrecreateResponse : AlipayResponse
    {
        /// <summary>
        /// 详细错误码。对返回响应码进行原因说明  当result_code响应码为SUCCESS时，不返回该参数。
        /// </summary>
        [JsonPropertyName("detail_error_code")]
        public string DetailErrorCode { get; set; }

        /// <summary>
        /// 对详细错误码进行文字说明  当result_code响应码为SUCCESS时，不返回该参数
        /// </summary>
        [JsonPropertyName("detail_error_des")]
        public string DetailErrorDes { get; set; }

        /// <summary>
        /// 错误代码。  请求成功时，不存在本参数；  请求失败时，本参数为错误代码
        /// </summary>
        [JsonPropertyName("error")]
        public string Error { get; set; }

        /// <summary>
        /// 请求是否成功。请求成功不代表业务处理成功  T代表成功  F代表失败
        /// </summary>
        [JsonPropertyName("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 对应商户网站的订单系统中的唯一订单号，非支付宝交易号。  需保证在商户网站中的唯一性。是请求时对应的参数，原样返回
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 二维码图片的URL地址
        /// </summary>
        [JsonPropertyName("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 二维码码串的内容
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 预下单处理结果响应码。  SUCCESS：预下单成功  FAIL：预下单失败  UNKNOWN：结果未知
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 支付宝交易号。该交易在支付宝系统中的交易流水号。  最短16位，最长64位
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 凭证类型，目前仅支持qrcode（二维码）
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
