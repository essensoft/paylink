using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskAudioVerifyModel Data Structure.
    /// </summary>
    public class SsdataDataserviceRiskAudioVerifyModel : AlipayObject
    {
        /// <summary>
        /// 需要识别的音频转换后的数据，不要包含特殊字符以及双引号等可能引起json格式化错误问题的字符.
        /// </summary>
        [JsonPropertyName("audio_content")]
        public string AudioContent { get; set; }

        /// <summary>
        /// 表明用户上传的音频数据格式
        /// </summary>
        [JsonPropertyName("audio_type")]
        public string AudioType { get; set; }

        /// <summary>
        /// 调用识别服务的用户id，与使用ssdata.dataservice.risk.audio.set的creator一致
        /// </summary>
        [JsonPropertyName("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 风险类型， 1-涉政模型， 2-涉黄模型
        /// </summary>
        [JsonPropertyName("risk_type")]
        public List<string> RiskType { get; set; }

        /// <summary>
        /// 表明用户上传的音频数据采样率
        /// </summary>
        [JsonPropertyName("sample_rate")]
        public string SampleRate { get; set; }
    }
}
