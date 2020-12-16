using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppletTaskDisplayVO Data Structure.
    /// </summary>
    public class AppletTaskDisplayVO : AlipayObject
    {
        /// <summary>
        /// 显示的任务未完成时的按钮文本。
        /// </summary>
        [JsonPropertyName("button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// 显示的任务已完成时的按钮文本。
        /// </summary>
        [JsonPropertyName("button_text_disabled")]
        public string ButtonTextDisabled { get; set; }

        /// <summary>
        /// 任务跳转链接。
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// 业务链接。
        /// </summary>
        [JsonPropertyName("promo_link")]
        public string PromoLink { get; set; }

        /// <summary>
        /// 任务标签图标链接。
        /// </summary>
        [JsonPropertyName("tag_icon")]
        public string TagIcon { get; set; }

        /// <summary>
        /// 任务标签后缀文案。
        /// </summary>
        [JsonPropertyName("tag_suffix")]
        public string TagSuffix { get; set; }

        /// <summary>
        /// 显示的任务描述。
        /// </summary>
        [JsonPropertyName("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 显示的任务图标链接。
        /// </summary>
        [JsonPropertyName("task_icon")]
        public string TaskIcon { get; set; }

        /// <summary>
        /// 显示的任务名称
        /// </summary>
        [JsonPropertyName("task_title")]
        public string TaskTitle { get; set; }
    }
}
