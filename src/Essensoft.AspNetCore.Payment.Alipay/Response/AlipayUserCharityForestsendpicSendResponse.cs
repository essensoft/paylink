using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserCharityForestsendpicSendResponse.
    /// </summary>
    public class AlipayUserCharityForestsendpicSendResponse : AlipayResponse
    {
        /// <summary>
        /// 结果代码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果文案
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 是否上传成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
