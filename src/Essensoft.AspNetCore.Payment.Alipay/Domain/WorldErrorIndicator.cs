using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WorldErrorIndicator Data Structure.
    /// </summary>
    public class WorldErrorIndicator : AlipayObject
    {
        /// <summary>
        /// 右动作按钮
        /// </summary>
        [JsonPropertyName("action_button")]
        public string ActionButton { get; set; }

        /// <summary>
        /// 右动作按钮目标地址
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 针对alipayInside的定制提示文案
        /// </summary>
        [JsonPropertyName("alipay_inside_tips")]
        public string AlipayInsideTips { get; set; }

        /// <summary>
        /// 清楚卡片提示
        /// </summary>
        [JsonPropertyName("clean_card")]
        public bool CleanCard { get; set; }

        /// <summary>
        /// 左动作按钮
        /// </summary>
        [JsonPropertyName("default_button")]
        public string DefaultButton { get; set; }

        /// <summary>
        /// 左动作按钮目标地址
        /// </summary>
        [JsonPropertyName("default_url")]
        public string DefaultUrl { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 客户端提示文案
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
