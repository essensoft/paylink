using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignAppleActivityConsultResponse.
    /// </summary>
    public class AlipayMarketingCampaignAppleActivityConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 活动参与状态 可参与/不可参与
        /// </summary>
        [JsonPropertyName("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 苹果绑定状态+已绑定/未绑定
        /// </summary>
        [JsonPropertyName("bind_status")]
        public string BindStatus { get; set; }

        /// <summary>
        /// 错误码 系统异常code 系统返回
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述 错误码对应的文字描述 系统返回
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 操作成功标识【true：成功；false：失败】
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
