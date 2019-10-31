using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniActivityModuleQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniActivityModuleQueryInfo : AlipayObject
    {
        /// <summary>
        /// 行动点文案
        /// </summary>
        [JsonProperty("action_text")]
        public string ActionText { get; set; }

        /// <summary>
        /// 记录唯一标识
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// logo
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [JsonProperty("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序页面
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [JsonProperty("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
