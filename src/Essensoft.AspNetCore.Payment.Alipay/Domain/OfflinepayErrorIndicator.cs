using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OfflinepayErrorIndicator Data Structure.
    /// </summary>
    public class OfflinepayErrorIndicator : AlipayObject
    {
        /// <summary>
        /// 右动作按钮
        /// </summary>
        [JsonPropertyName("action_button")]
        public string ActionButton { get; set; }

        /// <summary>
        /// 右动作按钮跳转地址
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 针对alipayinside的定制化提示文案
        /// </summary>
        [JsonPropertyName("alipay_inside_tips")]
        public string AlipayInsideTips { get; set; }

        /// <summary>
        /// 是否清楚卡片本地缓存
        /// </summary>
        [JsonPropertyName("clean_card")]
        public bool CleanCard { get; set; }

        /// <summary>
        /// 左动作按钮
        /// </summary>
        [JsonPropertyName("default_button")]
        public string DefaultButton { get; set; }

        /// <summary>
        /// 默认跳转地址
        /// </summary>
        [JsonPropertyName("default_url")]
        public string DefaultUrl { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 错误码值
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误提示文案
        /// </summary>
        [JsonPropertyName("tips")]
        public string Tips { get; set; }

        /// <summary>
        /// 客户端提示类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
