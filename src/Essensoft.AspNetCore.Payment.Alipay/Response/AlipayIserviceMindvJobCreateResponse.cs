using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceMindvJobCreateResponse.
    /// </summary>
    public class AlipayIserviceMindvJobCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 新增的问卷id数据
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 任务创建后发布的域名信息，枚举值:  ALIPAY(1, "surveys.alipay.com"),  ALIBABA_INC(2, "surveys.alibaba-inc.com"),  HEMAOS(3, "surveys.hemaos.com");
        /// </summary>
        [JsonPropertyName("job_domain")]
        public string JobDomain { get; set; }

        /// <summary>
        /// 任务状态信息_枚举值_用于判断当前任务状态_可通过检索任务获取    枚举值如下: WAIT_PUBLISH(等待发布),INNER_PUBLISHED(对内投放),TEST_PUBLISHED(测试投放),MANUAL_PUBLISHED(手动投放),GREY_PUBLISHED(灰度投放),FULL_PUBLISHED(全量投放),WAIT_TEST_PUBLISH(等待测试投放),WAIT_MANUAL_PUBLISH(等待全量投放),SCENE_PUBLISHED(场景投放)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 问卷/试卷标题信息
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
