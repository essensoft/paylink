using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserDtbankQrcodeCreateResponse.
    /// </summary>
    public class AlipayUserDtbankQrcodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 银行码码值
        /// </summary>
        [JsonPropertyName("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 银行码全局唯一Id
        /// </summary>
        [JsonPropertyName("qrcode_id")]
        public string QrcodeId { get; set; }

        /// <summary>
        /// 银行码外部展示Id
        /// </summary>
        [JsonPropertyName("qrcode_out_id")]
        public string QrcodeOutId { get; set; }
    }
}
