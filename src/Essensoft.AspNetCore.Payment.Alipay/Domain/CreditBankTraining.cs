using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditBankTraining Data Structure.
    /// </summary>
    public class CreditBankTraining : AlipayObject
    {
        /// <summary>
        /// 获取时间，格式yyyy-mm-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("experience_time")]
        public string ExperienceTime { get; set; }

        /// <summary>
        /// 是否有证，枚举1是2否
        /// </summary>
        [JsonPropertyName("have_project_certificate")]
        public long HaveProjectCertificate { get; set; }

        /// <summary>
        /// 办学机构
        /// </summary>
        [JsonPropertyName("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonPropertyName("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// 培训id
        /// </summary>
        [JsonPropertyName("training_outer_id")]
        public string TrainingOuterId { get; set; }
    }
}
