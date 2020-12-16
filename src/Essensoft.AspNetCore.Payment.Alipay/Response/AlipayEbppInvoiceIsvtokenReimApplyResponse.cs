using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceIsvtokenReimApplyResponse.
    /// </summary>
    public class AlipayEbppInvoiceIsvtokenReimApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝分配给报销软件的授权token，当前设置有效时间为20分钟
        /// </summary>
        [JsonPropertyName("isv_token")]
        public string IsvToken { get; set; }

        /// <summary>
        /// 该次请求的唯一标志，当前设置有效时间为20分钟
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }
    }
}
