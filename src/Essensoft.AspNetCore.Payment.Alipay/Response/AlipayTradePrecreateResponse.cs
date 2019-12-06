using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradePrecreateResponse.
    /// </summary>
    public class AlipayTradePrecreateResponse : AlipayResponse
    {
        /// <summary>
        /// 商户的订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 当前预下单请求生成的二维码码串，可以用二维码生成工具根据该码串值生成对应的二维码
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }
    }
}
