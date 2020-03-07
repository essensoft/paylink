using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MorphoAppItem Data Structure.
    /// </summary>
    public class MorphoAppItem : AlipayObject
    {
        /// <summary>
        /// 应用更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 闪蝶应用ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 小程序源数据
        /// </summary>
        [JsonPropertyName("mini_meta")]
        public MorphoMiniMeta MiniMeta { get; set; }

        /// <summary>
        /// 应用上线状态
        /// </summary>
        [JsonPropertyName("online_state")]
        public long OnlineState { get; set; }

        /// <summary>
        /// 闪蝶用户数据
        /// </summary>
        [JsonPropertyName("owner")]
        public MorphoUser Owner { get; set; }

        /// <summary>
        /// 应用状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 闪蝶应用名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
