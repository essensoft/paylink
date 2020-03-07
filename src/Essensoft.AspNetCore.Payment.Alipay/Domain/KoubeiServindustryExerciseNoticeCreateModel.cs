using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseNoticeCreateModel Data Structure.
    /// </summary>
    public class KoubeiServindustryExerciseNoticeCreateModel : AlipayObject
    {
        /// <summary>
        /// 外部通知ID
        /// </summary>
        [JsonPropertyName("external_notice_id")]
        public string ExternalNoticeId { get; set; }

        /// <summary>
        /// 健身ID
        /// </summary>
        [JsonPropertyName("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 有效期结束时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [JsonPropertyName("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 跳转链接类型
        /// </summary>
        [JsonPropertyName("jump_url_type")]
        public string JumpUrlType { get; set; }

        /// <summary>
        /// 外部请求ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 消息子类型
        /// </summary>
        [JsonPropertyName("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 通知模板动态参数
        /// </summary>
        [JsonPropertyName("template_args")]
        public NoticeTemplateArgs TemplateArgs { get; set; }

        /// <summary>
        /// 推送标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
