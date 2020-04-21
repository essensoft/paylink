using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceMindvJobCreateModel Data Structure.
    /// </summary>
    public class AlipayIserviceMindvJobCreateModel : AlipayObject
    {
        /// <summary>
        /// 任务创建后发布的域名信息，枚举值:  ALIPAY(1, "surveys.alipay.com"),  ALIBABA_INC(2, "surveys.alibaba-inc.com"),  HEMAOS(3, "surveys.hemaos.com");
        /// </summary>
        [JsonPropertyName("job_domain")]
        public string JobDomain { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [JsonPropertyName("staff_no")]
        public string StaffNo { get; set; }

        /// <summary>
        /// 问卷/试卷标题信息
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 问卷/试卷类型区别. 枚举值: QUESTION-问卷, EXAM-试卷
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
