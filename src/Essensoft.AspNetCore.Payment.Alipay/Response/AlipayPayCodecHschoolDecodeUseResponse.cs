using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPayCodecHschoolDecodeUseResponse.
    /// </summary>
    public class AlipayPayCodecHschoolDecodeUseResponse : AlipayResponse
    {
        /// <summary>
        /// 学生短号
        /// </summary>
        [JsonPropertyName("feature_code")]
        public string FeatureCode { get; set; }

        /// <summary>
        /// 红码 : "red"  黄码 :"yellow"  绿码 : "green" 审核中 :  "init" 未找到  : "notFound"
        /// </summary>
        [JsonPropertyName("health_status")]
        public string HealthStatus { get; set; }

        /// <summary>
        /// 学校编号（外标）
        /// </summary>
        [JsonPropertyName("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [JsonPropertyName("student_no")]
        public string StudentNo { get; set; }
    }
}
