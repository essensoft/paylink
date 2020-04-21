using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandAutomatApplyUploadResponse.
    /// </summary>
    public class AntMerchantExpandAutomatApplyUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝设备ID
        /// </summary>
        [JsonPropertyName("alipay_terminal_id")]
        public string AlipayTerminalId { get; set; }
    }
}
