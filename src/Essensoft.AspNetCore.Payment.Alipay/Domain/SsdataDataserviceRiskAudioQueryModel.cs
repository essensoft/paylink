using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskAudioQueryModel Data Structure.
    /// </summary>
    public class SsdataDataserviceRiskAudioQueryModel : AlipayObject
    {
        /// <summary>
        /// 调用识别服务的用户id，与使用ssdata.dataservice.risk.audio.set的creator一致
        /// </summary>
        [JsonPropertyName("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 用户音频请求唯一识别码
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 风险类型，1-涉政模型， 2-涉黄模型。与ssdata.dataservice.risk.audio.verify接口传数据时的参数保持一致。
        /// </summary>
        [JsonPropertyName("risk_type")]
        public List<string> RiskType { get; set; }
    }
}
