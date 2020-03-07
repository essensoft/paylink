using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantOrderCreditConfirmResponse.
    /// </summary>
    public class ZhimaMerchantOrderCreditConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码，业务处理完毕之后返回的错误码，成功码：SUCCESS
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息，错误码的解释说明，例如：成功
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 订单创建成功时间，格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonPropertyName("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 下单状态，下单成功状态为SUCCESS，失败:FAIL
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商户端订单号，回传商户
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 跳转至商户页面类型，目前共2种：order_result和order_detail，下单完成后为order_result，业务中间跳转类型为order_detail
        /// </summary>
        [JsonPropertyName("page_type")]
        public string PageType { get; set; }

        /// <summary>
        /// 业务处理是否成功，true：成功，false：失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 芝麻订单号，下单成功后回传给商户
        /// </summary>
        [JsonPropertyName("zm_order_no")]
        public string ZmOrderNo { get; set; }
    }
}
