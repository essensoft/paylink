using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAudioVerifyResponse.
    /// </summary>
    public class SsdataDataserviceRiskAudioVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 请求提交结果对应的音频唯一id，用于后续通过ssdata.dataservice.risk.audio.query接口查询结果的入参
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 业务唯一识别码
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
