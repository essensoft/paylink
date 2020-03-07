using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CdpDisplayContent Data Structure.
    /// </summary>
    public class CdpDisplayContent : AlipayObject
    {
        /// <summary>
        /// 点击投放内容跳转地址
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 投放中的扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 投放生效结束时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 投放生效开始时间
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 投放图片地址
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 投放文本内容
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// 投放类型字段（当前只有红包），红包redPacket、提示tips、全景ar、广告ad
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
