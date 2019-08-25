using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CdpDisplayContent Data Structure.
    /// </summary>
    [Serializable]
    public class CdpDisplayContent : AlipayObject
    {
        /// <summary>
        /// 点击投放内容跳转地址
        /// </summary>
        [JsonProperty("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 投放中的扩展字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 投放生效结束时间
        /// </summary>
        [JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 投放生效开始时间
        /// </summary>
        [JsonProperty("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 投放图片地址
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 投放文本内容
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// 投放类型字段（当前只有红包），红包redPacket、提示tips、全景ar、广告ad
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
