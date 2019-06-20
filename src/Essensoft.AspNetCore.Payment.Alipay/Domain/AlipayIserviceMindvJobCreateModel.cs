using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceMindvJobCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvJobCreateModel : AlipayObject
    {
        /// <summary>
        /// 任务创建后发布的域名信息，枚举值:  ALIPAY(1, "surveys.alipay.com"),  ALIBABA_INC(2, "surveys.alibaba-inc.com"),  HEMAOS(3, "surveys.hemaos.com");
        /// </summary>
        [JsonProperty("job_domain")]
        public string JobDomain { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [JsonProperty("staff_no")]
        public string StaffNo { get; set; }

        /// <summary>
        /// 问卷/试卷标题信息
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 问卷/试卷类型区别. 枚举值: QUESTION-问卷, EXAM-试卷
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
