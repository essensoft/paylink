using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniActivityModuleQueryInfo Data Structure.
    /// </summary>
    public class MiniActivityModuleQueryInfo : AlipayObject
    {
        /// <summary>
        /// 行动点文案
        /// </summary>
        [JsonPropertyName("action_text")]
        public string ActionText { get; set; }

        /// <summary>
        /// 记录唯一标识
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// logo
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序页面
        /// </summary>
        [JsonPropertyName("page")]
        public string Page { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [JsonPropertyName("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
