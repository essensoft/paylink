using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedMediaLinkInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaLinkInfo : AlipayObject
    {
        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 资源的来源
        /// </summary>
        [JsonProperty("content_source")]
        public string ContentSource { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 链接的缩略图
        /// </summary>
        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// linkurl
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
