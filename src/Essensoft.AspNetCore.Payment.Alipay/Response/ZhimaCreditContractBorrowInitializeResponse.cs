using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditContractBorrowInitializeResponse.
    /// </summary>
    public class ZhimaCreditContractBorrowInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// url：mode=0(二维码主扫模式)下，返回的url，在借还的机具上渲染为二维码后，用户使用支付宝扫一扫唤起该页面
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
