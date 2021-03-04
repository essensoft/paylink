using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntOcrGeneralIdentifyResponse.
    /// </summary>
    public class AntOcrGeneralIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
